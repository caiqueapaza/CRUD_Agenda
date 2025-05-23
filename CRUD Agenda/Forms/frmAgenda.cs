using CRUD_Agenda.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Agenda.Forms
{
    public partial class frmAgenda : Form
    {
        private int idUsuarioLogado;
        private int idAgenda;
        DB.Usuario usuario = new Usuario();
        DB.Agenda agenda = new Agenda();

        private void LimparCampos()
        {
            idAgenda = 0;
            txtAgeTitulo.Text = string.Empty;
            txtAgeDescricao.Text = string.Empty;
            mskAgeHora.Text = string.Empty; 
        }
        public frmAgenda(int idUsuario)
        {
            InitializeComponent();
            idUsuarioLogado = idUsuario;
        }

        private void mhcAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {
            CarregaAgenda();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            lblAgeNome.Text = "Olá " + usuario.ObterNomeUsuario(idUsuarioLogado);
            DataTable dt = agenda.ObterPermissaoAdm(idUsuarioLogado);

            if (dt != null && dt.Rows.Count > 0) 
            {
                btnAgeNovoUsuario.Visible = true;
            }
            CarregaAgenda();
        }

        public void CarregaAgenda()
        {
            LimparCampos(); 

            btnAgeAlterar.Enabled = false;
            btnAgeIncluir.Enabled = true;

            DateTime dtSelecionado = mhcAgenda.SelectionStart;

            dtgAgenda.DataSource = null;
            dtgAgenda.Rows.Clear();
            dtgAgenda.Columns.Clear();

            DataTable Agenda = agenda.ObterAgenda(idUsuarioLogado, dtSelecionado);

            dtgAgenda.Columns.Add("id", "idAgenda");
            dtgAgenda.Columns.Add("ds_hora", "Hora");
            dtgAgenda.Columns.Add("ds_titulo", "Título");
            dtgAgenda.Columns.Add("ds_descricao", "Descrição");
            dtgAgenda.Columns.Add("ds_status", "Status");

            dtgAgenda.Columns["id"].Visible = false;

            DataGridViewImageColumn colConcluir = new DataGridViewImageColumn();
            colConcluir.Name = "Concluir";
            colConcluir.HeaderText = "Concluir";
            colConcluir.Image = Properties.Resources.check;
            colConcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtgAgenda.Columns.Add(colConcluir);

            DataGridViewImageColumn colExcluir = new DataGridViewImageColumn();
            colExcluir.Name = "Excluir";
            colExcluir.HeaderText = "Excluir";
            colExcluir.Image = Properties.Resources.trash;
            colExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtgAgenda.Columns.Add(colExcluir);

            foreach (DataRow row in Agenda.Rows)
            {
                dtgAgenda.Rows.Add(row["id"], row["ds_hora"], row["ds_titulo"], row["ds_descricao"], row["ds_status"]);
            }
        }

        private void btnAgeIncluir_Click(object sender, EventArgs e)
        {
            DateTime dtAgenda = mhcAgenda.SelectionStart;
            string strTitulo = txtAgeTitulo.Text;
            string strDescricao = txtAgeDescricao.Text;
            string strHora = mskAgeHora.Text;

            if (strTitulo != "" && strDescricao != "" && strHora != "")
            {
                if (MessageBox.Show("Incluir nova agenda?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    agenda.IncluirAgenda(idUsuarioLogado, dtAgenda, strHora, strTitulo, strDescricao);

                    MessageBox.Show("Agenda incluida com sucesso!", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaAgenda();
                }
            }
            else
                MessageBox.Show("Favor preencher os campos para incluir a agenda!", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dtgAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAgenda = Convert.ToInt32(dtgAgenda.Rows[e.RowIndex].Cells["id"].Value);
                dtgAgenda.CurrentRow.Selected = true;
                txtAgeTitulo.Text = dtgAgenda.Rows[e.RowIndex].Cells["ds_titulo"].FormattedValue.ToString();
                mskAgeHora.Text = dtgAgenda.Rows[e.RowIndex].Cells["ds_hora"].FormattedValue.ToString();
                txtAgeDescricao.Text = dtgAgenda.Rows[e.RowIndex].Cells["ds_descricao"].FormattedValue.ToString();
                btnAgeIncluir.Enabled = false;
                btnAgeAlterar.Enabled = true;

                if (dtgAgenda.Columns[e.ColumnIndex].Name == "Concluir")
                {
                    if (MessageBox.Show("Deseja concluir essa agenda?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        agenda.ConcluirAgenda(idAgenda);
                        MessageBox.Show("Agenda concluída com sucesso!", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaAgenda();
                    }
                }
                else if (dtgAgenda.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    if (MessageBox.Show("Deseja excluir essa agenda?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        agenda.ExcluirAgenda(idAgenda);
                        MessageBox.Show("Agenda excluída com sucesso!", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaAgenda();
                    }
                }
            }
        }

        private void btnAgeLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnAgeAlterar.Enabled = false;
            btnAgeIncluir.Enabled = true;
        }

        private void btnAgeAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar essa agenda?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                agenda.AlterarAgenda(idAgenda, mskAgeHora.Text, txtAgeTitulo.Text, txtAgeDescricao.Text);
                btnAgeAlterar.Enabled = false;
                btnAgeIncluir.Enabled = true;
                CarregaAgenda();
            }
        }

        private void btnAgeNovoUsuario_Click(object sender, EventArgs e)
        {
            Forms.frmCadastro frmCadastro = new Forms.frmCadastro();
            frmCadastro.Show();
        }

        private void btnAgeSair_Click(object sender, EventArgs e)
        {
            Forms.frmLogin frmLogin = new Forms.frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}
