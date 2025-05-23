using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Agenda.Forms
{
    public partial class frmCadastro : Form
    {
        Forms.frmLogin fmrLogin = new Forms.frmLogin();
        
        private void LimparCampos()
        {
            txtCadNome.Text = string.Empty;
            txtCadEmail.Text = string.Empty;
            txtCadSenha.Text = string.Empty;
            cbxExibirSenha.Checked = false;
            cmbCadAdm.SelectedValue = 0;
        }
        public static bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public frmCadastro()
        {
            InitializeComponent();
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            var opcoes = new Dictionary<int, string>
            {
                { 1, "Sim" },
                { 0, "Não" }
            };

            cmbCadAdm.DataSource = new BindingSource(opcoes, null);
            cmbCadAdm.DisplayMember = "Value";
            cmbCadAdm.ValueMember = "Key";
            cmbCadAdm.SelectedValue = 0;

            LimparCampos();
        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxCadSenha_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selecionado = cbxExibirSenha.Checked;

            if (!selecionado)
            {
                txtCadSenha.PasswordChar = '*';
            }
            else
            {
                txtCadSenha.PasswordChar = '\0';
            }
        }

        private void btnCadCadastrar_Click(object sender, EventArgs e)
        {
            DB.Usuario usuario = new DB.Usuario();

            string strNomeUsuario = txtCadNome.Text;
            string strEmailUsuario = txtCadEmail.Text;
            string strSenhaUsuario = txtCadSenha.Text;
            int intAdm = (int)cmbCadAdm.SelectedValue;

            if (strNomeUsuario != "" || strEmailUsuario != "" || strSenhaUsuario != "")
            {
                if (strEmailUsuario != "" && !EmailValido(strEmailUsuario))
                {
                    MessageBox.Show("Favor digitar um e-mail válido", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Confirma o cadastro?", "Cadastro Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    usuario.CadastrarUsuario(strNomeUsuario, strEmailUsuario, strSenhaUsuario, intAdm);

                    MessageBox.Show("Cadastro feito com sucesso!", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

                    this.Hide();
                    fmrLogin.Show();
                }
            }
            else
                MessageBox.Show("Favor preencher todos os campos!", "Cadastro Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
