namespace Systemachamado
{
    partial class FormTelaCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaCadastroUser));
            this.panelCadastroUser = new System.Windows.Forms.Panel();
            this.textBoxPerfilCad = new System.Windows.Forms.ComboBox();
            this.textBoxIdCadUser = new System.Windows.Forms.TextBox();
            this.buttonCancelarCadLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenhaCad = new System.Windows.Forms.TextBox();
            this.textBoxSetorCad = new System.Windows.Forms.TextBox();
            this.labelSetor = new System.Windows.Forms.Label();
            this.textBoxNomeCad = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonDeletarCadLogin = new System.Windows.Forms.Button();
            this.buttonCadastroCadLogin = new System.Windows.Forms.Button();
            this.textBoxLoginCad = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxTelaLogin = new System.Windows.Forms.PictureBox();
            this.panelCadastroUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCadastroUser
            // 
            this.panelCadastroUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastroUser.Controls.Add(this.textBoxPerfilCad);
            this.panelCadastroUser.Controls.Add(this.textBoxIdCadUser);
            this.panelCadastroUser.Controls.Add(this.buttonCancelarCadLogin);
            this.panelCadastroUser.Controls.Add(this.label1);
            this.panelCadastroUser.Controls.Add(this.textBoxSenhaCad);
            this.panelCadastroUser.Controls.Add(this.textBoxSetorCad);
            this.panelCadastroUser.Controls.Add(this.labelSetor);
            this.panelCadastroUser.Controls.Add(this.textBoxNomeCad);
            this.panelCadastroUser.Controls.Add(this.labelNome);
            this.panelCadastroUser.Controls.Add(this.buttonDeletarCadLogin);
            this.panelCadastroUser.Controls.Add(this.buttonCadastroCadLogin);
            this.panelCadastroUser.Controls.Add(this.textBoxLoginCad);
            this.panelCadastroUser.Controls.Add(this.labelSenha);
            this.panelCadastroUser.Controls.Add(this.labelLogin);
            this.panelCadastroUser.Controls.Add(this.pictureBoxTelaLogin);
            this.panelCadastroUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadastroUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCadastroUser.Location = new System.Drawing.Point(0, 0);
            this.panelCadastroUser.Name = "panelCadastroUser";
            this.panelCadastroUser.Size = new System.Drawing.Size(395, 378);
            this.panelCadastroUser.TabIndex = 0;
            // 
            // textBoxPerfilCad
            // 
            this.textBoxPerfilCad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerfilCad.FormattingEnabled = true;
            this.textBoxPerfilCad.Items.AddRange(new object[] {
            "USUARIO",
            "ADMIN"});
            this.textBoxPerfilCad.Location = new System.Drawing.Point(78, 246);
            this.textBoxPerfilCad.Name = "textBoxPerfilCad";
            this.textBoxPerfilCad.Size = new System.Drawing.Size(241, 23);
            this.textBoxPerfilCad.TabIndex = 23;
            this.textBoxPerfilCad.Text = "USUARIO";
            // 
            // textBoxIdCadUser
            // 
            this.textBoxIdCadUser.Location = new System.Drawing.Point(334, 342);
            this.textBoxIdCadUser.Name = "textBoxIdCadUser";
            this.textBoxIdCadUser.Size = new System.Drawing.Size(48, 23);
            this.textBoxIdCadUser.TabIndex = 22;
            this.textBoxIdCadUser.Visible = false;
            // 
            // buttonCancelarCadLogin
            // 
            this.buttonCancelarCadLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCancelarCadLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelarCadLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadLogin.Location = new System.Drawing.Point(242, 327);
            this.buttonCancelarCadLogin.Name = "buttonCancelarCadLogin";
            this.buttonCancelarCadLogin.Size = new System.Drawing.Size(76, 39);
            this.buttonCancelarCadLogin.TabIndex = 8;
            this.buttonCancelarCadLogin.Text = "Cancelar";
            this.buttonCancelarCadLogin.UseVisualStyleBackColor = false;
            this.buttonCancelarCadLogin.Click += new System.EventHandler(this.buttonCancelarCadLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Perfil";
            // 
            // textBoxSenhaCad
            // 
            this.textBoxSenhaCad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaCad.Location = new System.Drawing.Point(219, 293);
            this.textBoxSenhaCad.Name = "textBoxSenhaCad";
            this.textBoxSenhaCad.Size = new System.Drawing.Size(100, 23);
            this.textBoxSenhaCad.TabIndex = 5;
            this.textBoxSenhaCad.UseSystemPasswordChar = true;
            // 
            // textBoxSetorCad
            // 
            this.textBoxSetorCad.AutoCompleteCustomSource.AddRange(new string[] {
            "SUPORTE FIDELIZAÇÃO",
            "\nCOORDENAÇÃO OPERACIONAL",
            "SUPERVISÃO COMERCIAL",
            "COORDENAÇÃO COMERCIAL",
            "GERÊNCIA COMERCIAL",
            "CONSULTORIA JURÍDICA",
            "ASSISTÊNCIA AO SPC",
            "DEACON",
            "ASSESSORIA JURÍDICA",
            "DIRETORIA",
            "INSTITUCIONAL",
            "PRESIDÊNCIA ",
            "SALA DE REUNIÕES",
            "SUPERINTENDÊNCIA",
            "ADMINISTRATIVO",
            "APOIO",
            "ARQUIVO GERAL",
            "CONTABILIDADE",
            "FINANCEIRO",
            "SETOR PESSOAL",
            "SALA DE TREINAMENTO CDL JOVEM",
            "EXPEDIÇÃO",
            "NOTIFICAÇÃO",
            "RH",
            "JURÍDICO",
            "DEPARTAMENTO PESSOAL"});
            this.textBoxSetorCad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSetorCad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSetorCad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetorCad.Location = new System.Drawing.Point(78, 195);
            this.textBoxSetorCad.Name = "textBoxSetorCad";
            this.textBoxSetorCad.Size = new System.Drawing.Size(240, 23);
            this.textBoxSetorCad.TabIndex = 2;
            this.textBoxSetorCad.TextChanged += new System.EventHandler(this.textBoxSetorCad_TextChanged);
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetor.Location = new System.Drawing.Point(75, 174);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(41, 16);
            this.labelSetor.TabIndex = 16;
            this.labelSetor.Text = "Setor";
            // 
            // textBoxNomeCad
            // 
            this.textBoxNomeCad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeCad.Location = new System.Drawing.Point(78, 149);
            this.textBoxNomeCad.Name = "textBoxNomeCad";
            this.textBoxNomeCad.Size = new System.Drawing.Size(240, 23);
            this.textBoxNomeCad.TabIndex = 1;
            this.textBoxNomeCad.TextChanged += new System.EventHandler(this.textBoxNomeCad_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(75, 128);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(108, 16);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Nome Completo";
            // 
            // buttonDeletarCadLogin
            // 
            this.buttonDeletarCadLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDeletarCadLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeletarCadLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarCadLogin.Location = new System.Drawing.Point(160, 327);
            this.buttonDeletarCadLogin.Name = "buttonDeletarCadLogin";
            this.buttonDeletarCadLogin.Size = new System.Drawing.Size(76, 39);
            this.buttonDeletarCadLogin.TabIndex = 7;
            this.buttonDeletarCadLogin.Text = "Deletar";
            this.buttonDeletarCadLogin.UseVisualStyleBackColor = false;
            this.buttonDeletarCadLogin.Click += new System.EventHandler(this.buttonDeletarCadLogin_Click);
            // 
            // buttonCadastroCadLogin
            // 
            this.buttonCadastroCadLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCadastroCadLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCadastroCadLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroCadLogin.Location = new System.Drawing.Point(76, 327);
            this.buttonCadastroCadLogin.Name = "buttonCadastroCadLogin";
            this.buttonCadastroCadLogin.Size = new System.Drawing.Size(78, 39);
            this.buttonCadastroCadLogin.TabIndex = 6;
            this.buttonCadastroCadLogin.Text = "Salvar";
            this.buttonCadastroCadLogin.UseVisualStyleBackColor = false;
            this.buttonCadastroCadLogin.Click += new System.EventHandler(this.buttonCadastroCadLogin_Click);
            // 
            // textBoxLoginCad
            // 
            this.textBoxLoginCad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginCad.Location = new System.Drawing.Point(77, 292);
            this.textBoxLoginCad.Name = "textBoxLoginCad";
            this.textBoxLoginCad.Size = new System.Drawing.Size(138, 23);
            this.textBoxLoginCad.TabIndex = 4;
            this.textBoxLoginCad.TextChanged += new System.EventHandler(this.textBoxLoginCad_TextChanged);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(216, 273);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(45, 16);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "Senha";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(74, 272);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 16);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            // 
            // pictureBoxTelaLogin
            // 
            this.pictureBoxTelaLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTelaLogin.Image")));
            this.pictureBoxTelaLogin.Location = new System.Drawing.Point(100, -12);
            this.pictureBoxTelaLogin.Name = "pictureBoxTelaLogin";
            this.pictureBoxTelaLogin.Size = new System.Drawing.Size(182, 178);
            this.pictureBoxTelaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTelaLogin.TabIndex = 13;
            this.pictureBoxTelaLogin.TabStop = false;
            // 
            // FormTelaCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 378);
            this.Controls.Add(this.panelCadastroUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTelaCadastroUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTelaCadastroUser";
            this.panelCadastroUser.ResumeLayout(false);
            this.panelCadastroUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastroUser;
        private System.Windows.Forms.PictureBox pictureBoxTelaLogin;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.Button buttonCancelarCadLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeletarCadLogin;
        private System.Windows.Forms.Button buttonCadastroCadLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.TextBox textBoxNomeCad;
        public System.Windows.Forms.TextBox textBoxSetorCad;
        public System.Windows.Forms.TextBox textBoxSenhaCad;
        public System.Windows.Forms.TextBox textBoxLoginCad;
        public System.Windows.Forms.TextBox textBoxIdCadUser;
        public System.Windows.Forms.ComboBox textBoxPerfilCad;
    }
}