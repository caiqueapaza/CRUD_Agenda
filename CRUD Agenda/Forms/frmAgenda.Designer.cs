namespace CRUD_Agenda.Forms
{
    partial class frmAgenda
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
            this.mhcAgenda = new System.Windows.Forms.MonthCalendar();
            this.btnAgeIncluir = new System.Windows.Forms.Button();
            this.btnAgeAlterar = new System.Windows.Forms.Button();
            this.lblAgeTitulo = new System.Windows.Forms.Label();
            this.txtAgeTitulo = new System.Windows.Forms.TextBox();
            this.lblAgeDescricao = new System.Windows.Forms.Label();
            this.txtAgeDescricao = new System.Windows.Forms.TextBox();
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.lblAgeNome = new System.Windows.Forms.Label();
            this.lblAgeHora = new System.Windows.Forms.Label();
            this.mskAgeHora = new System.Windows.Forms.MaskedTextBox();
            this.btnAgeLimpar = new System.Windows.Forms.Button();
            this.btnAgeSair = new System.Windows.Forms.Button();
            this.btnAgeNovoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // mhcAgenda
            // 
            this.mhcAgenda.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mhcAgenda.Location = new System.Drawing.Point(16, 54);
            this.mhcAgenda.Name = "mhcAgenda";
            this.mhcAgenda.TabIndex = 2;
            this.mhcAgenda.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mhcAgenda_DateSelected);
            // 
            // btnAgeIncluir
            // 
            this.btnAgeIncluir.Location = new System.Drawing.Point(312, 231);
            this.btnAgeIncluir.Name = "btnAgeIncluir";
            this.btnAgeIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnAgeIncluir.TabIndex = 3;
            this.btnAgeIncluir.Text = "Incluir";
            this.btnAgeIncluir.UseVisualStyleBackColor = true;
            this.btnAgeIncluir.Click += new System.EventHandler(this.btnAgeIncluir_Click);
            // 
            // btnAgeAlterar
            // 
            this.btnAgeAlterar.Enabled = false;
            this.btnAgeAlterar.Location = new System.Drawing.Point(404, 231);
            this.btnAgeAlterar.Name = "btnAgeAlterar";
            this.btnAgeAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeAlterar.TabIndex = 3;
            this.btnAgeAlterar.Text = "Alterar";
            this.btnAgeAlterar.UseVisualStyleBackColor = true;
            this.btnAgeAlterar.Click += new System.EventHandler(this.btnAgeAlterar_Click);
            // 
            // lblAgeTitulo
            // 
            this.lblAgeTitulo.AutoSize = true;
            this.lblAgeTitulo.Location = new System.Drawing.Point(269, 58);
            this.lblAgeTitulo.Name = "lblAgeTitulo";
            this.lblAgeTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblAgeTitulo.TabIndex = 4;
            this.lblAgeTitulo.Text = "Título:";
            // 
            // txtAgeTitulo
            // 
            this.txtAgeTitulo.Location = new System.Drawing.Point(311, 58);
            this.txtAgeTitulo.Name = "txtAgeTitulo";
            this.txtAgeTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtAgeTitulo.TabIndex = 5;
            // 
            // lblAgeDescricao
            // 
            this.lblAgeDescricao.AutoSize = true;
            this.lblAgeDescricao.Location = new System.Drawing.Point(249, 84);
            this.lblAgeDescricao.Name = "lblAgeDescricao";
            this.lblAgeDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblAgeDescricao.TabIndex = 4;
            this.lblAgeDescricao.Text = "Descrição:";
            // 
            // txtAgeDescricao
            // 
            this.txtAgeDescricao.Location = new System.Drawing.Point(311, 84);
            this.txtAgeDescricao.Multiline = true;
            this.txtAgeDescricao.Name = "txtAgeDescricao";
            this.txtAgeDescricao.Size = new System.Drawing.Size(330, 132);
            this.txtAgeDescricao.TabIndex = 5;
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.Location = new System.Drawing.Point(12, 270);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.ReadOnly = true;
            this.dtgAgenda.Size = new System.Drawing.Size(629, 232);
            this.dtgAgenda.TabIndex = 6;
            this.dtgAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgenda_CellClick);
            // 
            // lblAgeNome
            // 
            this.lblAgeNome.AutoSize = true;
            this.lblAgeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeNome.Location = new System.Drawing.Point(16, 13);
            this.lblAgeNome.Name = "lblAgeNome";
            this.lblAgeNome.Size = new System.Drawing.Size(230, 29);
            this.lblAgeNome.TabIndex = 7;
            this.lblAgeNome.Text = "Olá *nome usuário";
            // 
            // lblAgeHora
            // 
            this.lblAgeHora.AutoSize = true;
            this.lblAgeHora.Location = new System.Drawing.Point(442, 58);
            this.lblAgeHora.Name = "lblAgeHora";
            this.lblAgeHora.Size = new System.Drawing.Size(33, 13);
            this.lblAgeHora.TabIndex = 4;
            this.lblAgeHora.Text = "Hora:";
            // 
            // mskAgeHora
            // 
            this.mskAgeHora.Location = new System.Drawing.Point(482, 57);
            this.mskAgeHora.Mask = "00:00";
            this.mskAgeHora.Name = "mskAgeHora";
            this.mskAgeHora.Size = new System.Drawing.Size(44, 20);
            this.mskAgeHora.TabIndex = 8;
            // 
            // btnAgeLimpar
            // 
            this.btnAgeLimpar.Location = new System.Drawing.Point(495, 230);
            this.btnAgeLimpar.Name = "btnAgeLimpar";
            this.btnAgeLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeLimpar.TabIndex = 9;
            this.btnAgeLimpar.Text = "Limpar";
            this.btnAgeLimpar.UseVisualStyleBackColor = true;
            this.btnAgeLimpar.Click += new System.EventHandler(this.btnAgeLimpar_Click);
            // 
            // btnAgeSair
            // 
            this.btnAgeSair.Location = new System.Drawing.Point(566, 529);
            this.btnAgeSair.Name = "btnAgeSair";
            this.btnAgeSair.Size = new System.Drawing.Size(75, 23);
            this.btnAgeSair.TabIndex = 10;
            this.btnAgeSair.Text = "Sair";
            this.btnAgeSair.UseVisualStyleBackColor = true;
            this.btnAgeSair.Click += new System.EventHandler(this.btnAgeSair_Click);
            // 
            // btnAgeNovoUsuario
            // 
            this.btnAgeNovoUsuario.Location = new System.Drawing.Point(12, 529);
            this.btnAgeNovoUsuario.Name = "btnAgeNovoUsuario";
            this.btnAgeNovoUsuario.Size = new System.Drawing.Size(115, 23);
            this.btnAgeNovoUsuario.TabIndex = 10;
            this.btnAgeNovoUsuario.Text = "Novo Usuário";
            this.btnAgeNovoUsuario.UseVisualStyleBackColor = true;
            this.btnAgeNovoUsuario.Visible = false;
            this.btnAgeNovoUsuario.Click += new System.EventHandler(this.btnAgeNovoUsuario_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 564);
            this.Controls.Add(this.btnAgeNovoUsuario);
            this.Controls.Add(this.btnAgeSair);
            this.Controls.Add(this.btnAgeLimpar);
            this.Controls.Add(this.mskAgeHora);
            this.Controls.Add(this.lblAgeNome);
            this.Controls.Add(this.dtgAgenda);
            this.Controls.Add(this.txtAgeDescricao);
            this.Controls.Add(this.lblAgeDescricao);
            this.Controls.Add(this.lblAgeHora);
            this.Controls.Add(this.txtAgeTitulo);
            this.Controls.Add(this.lblAgeTitulo);
            this.Controls.Add(this.btnAgeAlterar);
            this.Controls.Add(this.btnAgeIncluir);
            this.Controls.Add(this.mhcAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar mhcAgenda;
        private System.Windows.Forms.Button btnAgeIncluir;
        private System.Windows.Forms.Button btnAgeAlterar;
        private System.Windows.Forms.Label lblAgeTitulo;
        private System.Windows.Forms.TextBox txtAgeTitulo;
        private System.Windows.Forms.Label lblAgeDescricao;
        private System.Windows.Forms.TextBox txtAgeDescricao;
        private System.Windows.Forms.DataGridView dtgAgenda;
        private System.Windows.Forms.Label lblAgeNome;
        private System.Windows.Forms.Label lblAgeHora;
        private System.Windows.Forms.MaskedTextBox mskAgeHora;
        private System.Windows.Forms.Button btnAgeLimpar;
        private System.Windows.Forms.Button btnAgeSair;
        private System.Windows.Forms.Button btnAgeNovoUsuario;
    }
}