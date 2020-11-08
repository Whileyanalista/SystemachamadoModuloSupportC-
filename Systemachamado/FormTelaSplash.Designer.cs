namespace Systemachamado
{
    partial class FormTelaSplash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaSplash));
            this.panelTelaSplah = new System.Windows.Forms.Panel();
            this.progressBarTelaSplah = new System.Windows.Forms.ProgressBar();
            this.pictureBoxTelaSplashTSP = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTelaSplah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaSplashTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTelaSplah
            // 
            this.panelTelaSplah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTelaSplah.Controls.Add(this.progressBarTelaSplah);
            this.panelTelaSplah.Controls.Add(this.pictureBoxTelaSplashTSP);
            this.panelTelaSplah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTelaSplah.Location = new System.Drawing.Point(0, 0);
            this.panelTelaSplah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTelaSplah.Name = "panelTelaSplah";
            this.panelTelaSplah.Size = new System.Drawing.Size(589, 263);
            this.panelTelaSplah.TabIndex = 0;
            // 
            // progressBarTelaSplah
            // 
            this.progressBarTelaSplah.Location = new System.Drawing.Point(71, 229);
            this.progressBarTelaSplah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarTelaSplah.Name = "progressBarTelaSplah";
            this.progressBarTelaSplah.Size = new System.Drawing.Size(464, 18);
            this.progressBarTelaSplah.TabIndex = 1;
            // 
            // pictureBoxTelaSplashTSP
            // 
            this.pictureBoxTelaSplashTSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTelaSplashTSP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTelaSplashTSP.Image")));
            this.pictureBoxTelaSplashTSP.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTelaSplashTSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxTelaSplashTSP.Name = "pictureBoxTelaSplashTSP";
            this.pictureBoxTelaSplashTSP.Size = new System.Drawing.Size(587, 261);
            this.pictureBoxTelaSplashTSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTelaSplashTSP.TabIndex = 0;
            this.pictureBoxTelaSplashTSP.TabStop = false;
            this.pictureBoxTelaSplashTSP.Click += new System.EventHandler(this.pictureBoxTelaSplash_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormTelaSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 263);
            this.Controls.Add(this.panelTelaSplah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTelaSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTelaSplah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaSplashTSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTelaSplah;
        private System.Windows.Forms.PictureBox pictureBoxTelaSplashTSP;
        private System.Windows.Forms.ProgressBar progressBarTelaSplah;
        private System.Windows.Forms.Timer timer1;
    }
}

