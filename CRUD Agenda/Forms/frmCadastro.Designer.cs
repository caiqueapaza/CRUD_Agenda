namespace CRUD_Agenda.Forms
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCadNome = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.lblCadAdm = new System.Windows.Forms.Label();
            this.cbxExibirSenha = new System.Windows.Forms.CheckBox();
            this.btnCadCadastrar = new System.Windows.Forms.Button();
            this.btnCadVoltar = new System.Windows.Forms.Button();
            this.cmbCadAdm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.Location = new System.Drawing.Point(51, 45);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(38, 13);
            this.lblCadNome.TabIndex = 0;
            this.lblCadNome.Text = "Nome:";
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(88, 45);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(214, 20);
            this.txtCadNome.TabIndex = 0;
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.Location = new System.Drawing.Point(51, 71);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCadEmail.TabIndex = 0;
            this.lblCadEmail.Text = "Email:";
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.Location = new System.Drawing.Point(88, 71);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(214, 20);
            this.txtCadEmail.TabIndex = 1;
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Location = new System.Drawing.Point(51, 97);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(41, 13);
            this.lblCadSenha.TabIndex = 0;
            this.lblCadSenha.Text = "Senha:";
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(88, 97);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.PasswordChar = '*';
            this.txtCadSenha.Size = new System.Drawing.Size(214, 20);
            this.txtCadSenha.TabIndex = 2;
            // 
            // lblCadAdm
            // 
            this.lblCadAdm.AutoSize = true;
            this.lblCadAdm.Location = new System.Drawing.Point(51, 138);
            this.lblCadAdm.Name = "lblCadAdm";
            this.lblCadAdm.Size = new System.Drawing.Size(76, 13);
            this.lblCadAdm.TabIndex = 0;
            this.lblCadAdm.Text = "Administrador?";
            // 
            // cbxExibirSenha
            // 
            this.cbxExibirSenha.AutoSize = true;
            this.cbxExibirSenha.Location = new System.Drawing.Point(308, 100);
            this.cbxExibirSenha.Name = "cbxExibirSenha";
            this.cbxExibirSenha.Size = new System.Drawing.Size(38, 17);
            this.cbxExibirSenha.TabIndex = 3;
            this.cbxExibirSenha.Text = "👁️";
            this.cbxExibirSenha.UseVisualStyleBackColor = true;
            this.cbxExibirSenha.CheckedChanged += new System.EventHandler(this.cbxCadSenha_SelectedIndexChanged);
            // 
            // btnCadCadastrar
            // 
            this.btnCadCadastrar.Location = new System.Drawing.Point(99, 194);
            this.btnCadCadastrar.Name = "btnCadCadastrar";
            this.btnCadCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadCadastrar.TabIndex = 5;
            this.btnCadCadastrar.Text = "Cadastrar";
            this.btnCadCadastrar.UseVisualStyleBackColor = true;
            this.btnCadCadastrar.Click += new System.EventHandler(this.btnCadCadastrar_Click);
            // 
            // btnCadVoltar
            // 
            this.btnCadVoltar.Location = new System.Drawing.Point(207, 194);
            this.btnCadVoltar.Name = "btnCadVoltar";
            this.btnCadVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnCadVoltar.TabIndex = 6;
            this.btnCadVoltar.Text = "Voltar";
            this.btnCadVoltar.UseVisualStyleBackColor = true;
            this.btnCadVoltar.Click += new System.EventHandler(this.btnCadVoltar_Click);
            // 
            // cmbCadAdm
            // 
            this.cmbCadAdm.FormattingEnabled = true;
            this.cmbCadAdm.Location = new System.Drawing.Point(133, 138);
            this.cmbCadAdm.Name = "cmbCadAdm";
            this.cmbCadAdm.Size = new System.Drawing.Size(95, 21);
            this.cmbCadAdm.TabIndex = 4;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.cmbCadAdm);
            this.Controls.Add(this.btnCadVoltar);
            this.Controls.Add(this.btnCadCadastrar);
            this.Controls.Add(this.cbxExibirSenha);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.lblCadAdm);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.lblCadEmail);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.TextBox txtCadEmail;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Label lblCadAdm;
        private System.Windows.Forms.CheckBox cbxExibirSenha;
        private System.Windows.Forms.Button btnCadCadastrar;
        private System.Windows.Forms.Button btnCadVoltar;
        private System.Windows.Forms.ComboBox cmbCadAdm;
    }
}