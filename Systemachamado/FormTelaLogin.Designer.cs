namespace Systemachamado
{
    partial class FormTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaLogin));
            this.pictureBoxTelaLogin = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonAcessarLog = new System.Windows.Forms.Button();
            this.buttonCancelarLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTelaLogin
            // 
            this.pictureBoxTelaLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTelaLogin.Image")));
            this.pictureBoxTelaLogin.Location = new System.Drawing.Point(12, 24);
            this.pictureBoxTelaLogin.Name = "pictureBoxTelaLogin";
            this.pictureBoxTelaLogin.Size = new System.Drawing.Size(175, 182);
            this.pictureBoxTelaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTelaLogin.TabIndex = 0;
            this.pictureBoxTelaLogin.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(212, 66);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(212, 118);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(50, 17);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(215, 87);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(158, 25);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(215, 138);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(158, 23);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSenha_KeyPress);
            // 
            // buttonAcessarLog
            // 
            this.buttonAcessarLog.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAcessarLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAcessarLog.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcessarLog.Location = new System.Drawing.Point(215, 169);
            this.buttonAcessarLog.Name = "buttonAcessarLog";
            this.buttonAcessarLog.Size = new System.Drawing.Size(77, 39);
            this.buttonAcessarLog.TabIndex = 3;
            this.buttonAcessarLog.Text = "Acessar";
            this.buttonAcessarLog.UseVisualStyleBackColor = false;
            this.buttonAcessarLog.Click += new System.EventHandler(this.buttonAcessar_Click);
            // 
            // buttonCancelarLog
            // 
            this.buttonCancelarLog.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCancelarLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelarLog.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarLog.Location = new System.Drawing.Point(296, 169);
            this.buttonCancelarLog.Name = "buttonCancelarLog";
            this.buttonCancelarLog.Size = new System.Drawing.Size(77, 39);
            this.buttonCancelarLog.TabIndex = 4;
            this.buttonCancelarLog.Text = "Cancelar";
            this.buttonCancelarLog.UseVisualStyleBackColor = false;
            this.buttonCancelarLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 233);
            this.Controls.Add(this.buttonCancelarLog);
            this.Controls.Add(this.buttonAcessarLog);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBoxTelaLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTelaLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTelaLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonAcessarLog;
        private System.Windows.Forms.Button buttonCancelarLog;
    }
}