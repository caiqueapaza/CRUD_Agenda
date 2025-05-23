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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Forms.frmCadastro frmCadastro = new Forms.frmCadastro();
            frmCadastro.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DB.Usuario usuario = new DB.Usuario();

            int qtdUsuarios = usuario.VerificaUsuarioExistente();

            if (qtdUsuarios <=0)
            {
                btnCadastrar.Visible = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DB.Usuario usuario = new DB.Usuario();

            string strUsuario = txtEntrarUsuario.Text;
            string strSenha = txtEntrarSenha.Text;

            if (strUsuario != "" || strSenha != "")
            {
                if (!usuario.VerificarUsuario(strUsuario, strSenha))
                {
                    MessageBox.Show("Usuário ou Senha inválido!", "Entrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int idUsuario = usuario.ObterIdUsuario(strUsuario);
                    Forms.frmAgenda frmAgenda = new Forms.frmAgenda(idUsuario);
                    this.Hide();
                    frmAgenda.Show();
                }
            }
            else
                MessageBox.Show("Digite usuário e senha", "Entrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
        }
    }
}
