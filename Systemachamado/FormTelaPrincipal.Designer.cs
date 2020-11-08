namespace Systemachamado
{
    partial class FormTelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.textBoxSetorTP = new System.Windows.Forms.TextBox();
            this.textBoxIdUserTelaPrin = new System.Windows.Forms.TextBox();
            this.textBoxNomeUserTelaPrin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCriaTicket = new System.Windows.Forms.Button();
            this.panelPainel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeTP = new System.Windows.Forms.TextBox();
            this.comboBoxStatusTP = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.maskedTextBoxFechamentoTP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAberturaTP = new System.Windows.Forms.MaskedTextBox();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.labelDataAbertura = new System.Windows.Forms.Label();
            this.labelPesquisaPainel = new System.Windows.Forms.Label();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStripTelaInicial = new System.Windows.Forms.MenuStrip();
            this.chamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTelaPrincipal = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelChamado = new System.Windows.Forms.Panel();
            this.dataGridViewTabChamadoTP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTabUsuarioTP = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.panelPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
            this.menuStripTelaInicial.SuspendLayout();
            this.panelTelaPrincipal.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelChamado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabChamadoTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabUsuarioTP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.Window;
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Controls.Add(this.buttonRelatorio);
            this.panelSuperior.Controls.Add(this.textBoxSetorTP);
            this.panelSuperior.Controls.Add(this.textBoxIdUserTelaPrin);
            this.panelSuperior.Controls.Add(this.textBoxNomeUserTelaPrin);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Controls.Add(this.buttonCriaTicket);
            this.panelSuperior.Controls.Add(this.panelPainel);
            this.panelSuperior.Controls.Add(this.buttonCadastro);
            this.panelSuperior.Controls.Add(this.P);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1161, 113);
            this.panelSuperior.TabIndex = 0;
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRelatorio.BackgroundImage")));
            this.buttonRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRelatorio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRelatorio.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelatorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRelatorio.Location = new System.Drawing.Point(276, 4);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(97, 105);
            this.buttonRelatorio.TabIndex = 8;
            this.buttonRelatorio.Text = "RELATORIO";
            this.buttonRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRelatorio.UseVisualStyleBackColor = false;
            this.buttonRelatorio.Click += new System.EventHandler(this.buttonRelatorio_Click);
            // 
            // textBoxSetorTP
            // 
            this.textBoxSetorTP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSetorTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSetorTP.Enabled = false;
            this.textBoxSetorTP.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetorTP.Location = new System.Drawing.Point(958, 63);
            this.textBoxSetorTP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSetorTP.Name = "textBoxSetorTP";
            this.textBoxSetorTP.Size = new System.Drawing.Size(159, 22);
            this.textBoxSetorTP.TabIndex = 7;
            this.textBoxSetorTP.Visible = false;
            // 
            // textBoxIdUserTelaPrin
            // 
            this.textBoxIdUserTelaPrin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxIdUserTelaPrin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdUserTelaPrin.Enabled = false;
            this.textBoxIdUserTelaPrin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdUserTelaPrin.Location = new System.Drawing.Point(908, 63);
            this.textBoxIdUserTelaPrin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdUserTelaPrin.Name = "textBoxIdUserTelaPrin";
            this.textBoxIdUserTelaPrin.Size = new System.Drawing.Size(46, 22);
            this.textBoxIdUserTelaPrin.TabIndex = 6;
            this.textBoxIdUserTelaPrin.Visible = false;
            // 
            // textBoxNomeUserTelaPrin
            // 
            this.textBoxNomeUserTelaPrin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxNomeUserTelaPrin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeUserTelaPrin.Enabled = false;
            this.textBoxNomeUserTelaPrin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeUserTelaPrin.Location = new System.Drawing.Point(905, 37);
            this.textBoxNomeUserTelaPrin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeUserTelaPrin.Name = "textBoxNomeUserTelaPrin";
            this.textBoxNomeUserTelaPrin.Size = new System.Drawing.Size(284, 22);
            this.textBoxNomeUserTelaPrin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bem Vindo !!!";
            // 
            // buttonCriaTicket
            // 
            this.buttonCriaTicket.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCriaTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCriaTicket.BackgroundImage")));
            this.buttonCriaTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCriaTicket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCriaTicket.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriaTicket.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonCriaTicket.Location = new System.Drawing.Point(171, 3);
            this.buttonCriaTicket.Name = "buttonCriaTicket";
            this.buttonCriaTicket.Size = new System.Drawing.Size(97, 105);
            this.buttonCriaTicket.TabIndex = 3;
            this.buttonCriaTicket.Text = "CRIAR TICHET";
            this.buttonCriaTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCriaTicket.UseVisualStyleBackColor = false;
            this.buttonCriaTicket.Click += new System.EventHandler(this.buttonCriaTicket_Click);
            // 
            // panelPainel
            // 
            this.panelPainel.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPainel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPainel.Controls.Add(this.label3);
            this.panelPainel.Controls.Add(this.textBoxNomeTP);
            this.panelPainel.Controls.Add(this.comboBoxStatusTP);
            this.panelPainel.Controls.Add(this.labelStatus);
            this.panelPainel.Controls.Add(this.maskedTextBoxFechamentoTP);
            this.panelPainel.Controls.Add(this.maskedTextBoxAberturaTP);
            this.panelPainel.Controls.Add(this.labelDataSaida);
            this.panelPainel.Controls.Add(this.labelDataAbertura);
            this.panelPainel.Controls.Add(this.labelPesquisaPainel);
            this.panelPainel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPainel.Location = new System.Drawing.Point(380, 7);
            this.panelPainel.Name = "panelPainel";
            this.panelPainel.Size = new System.Drawing.Size(513, 100);
            this.panelPainel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nome";
            // 
            // textBoxNomeTP
            // 
            this.textBoxNomeTP.Location = new System.Drawing.Point(346, 56);
            this.textBoxNomeTP.Name = "textBoxNomeTP";
            this.textBoxNomeTP.Size = new System.Drawing.Size(155, 25);
            this.textBoxNomeTP.TabIndex = 5;
            this.textBoxNomeTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeTP_KeyPress);
            // 
            // comboBoxStatusTP
            // 
            this.comboBoxStatusTP.FormattingEnabled = true;
            this.comboBoxStatusTP.Items.AddRange(new object[] {
            "PENDENTE",
            "ENTREGUE"});
            this.comboBoxStatusTP.Location = new System.Drawing.Point(219, 56);
            this.comboBoxStatusTP.Name = "comboBoxStatusTP";
            this.comboBoxStatusTP.Size = new System.Drawing.Size(121, 25);
            this.comboBoxStatusTP.TabIndex = 4;
            this.comboBoxStatusTP.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusTP_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(216, 35);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 15);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // maskedTextBoxFechamentoTP
            // 
            this.maskedTextBoxFechamentoTP.Location = new System.Drawing.Point(113, 56);
            this.maskedTextBoxFechamentoTP.Mask = "00/00/0000";
            this.maskedTextBoxFechamentoTP.Name = "maskedTextBoxFechamentoTP";
            this.maskedTextBoxFechamentoTP.Size = new System.Drawing.Size(100, 25);
            this.maskedTextBoxFechamentoTP.TabIndex = 3;
            this.maskedTextBoxFechamentoTP.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFechamentoTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxFechamentoTP_KeyPress);
            // 
            // maskedTextBoxAberturaTP
            // 
            this.maskedTextBoxAberturaTP.Location = new System.Drawing.Point(7, 56);
            this.maskedTextBoxAberturaTP.Mask = "00/00/0000";
            this.maskedTextBoxAberturaTP.Name = "maskedTextBoxAberturaTP";
            this.maskedTextBoxAberturaTP.Size = new System.Drawing.Size(100, 25);
            this.maskedTextBoxAberturaTP.TabIndex = 2;
            this.maskedTextBoxAberturaTP.ValidatingType = typeof(System.DateTime);
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSaida.Location = new System.Drawing.Point(110, 36);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(60, 15);
            this.labelDataSaida.TabIndex = 2;
            this.labelDataSaida.Text = "Retirada";
            // 
            // labelDataAbertura
            // 
            this.labelDataAbertura.AutoSize = true;
            this.labelDataAbertura.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataAbertura.Location = new System.Drawing.Point(4, 35);
            this.labelDataAbertura.Name = "labelDataAbertura";
            this.labelDataAbertura.Size = new System.Drawing.Size(62, 15);
            this.labelDataAbertura.TabIndex = 1;
            this.labelDataAbertura.Text = "Abertura";
            // 
            // labelPesquisaPainel
            // 
            this.labelPesquisaPainel.AutoSize = true;
            this.labelPesquisaPainel.Location = new System.Drawing.Point(1, 0);
            this.labelPesquisaPainel.Name = "labelPesquisaPainel";
            this.labelPesquisaPainel.Size = new System.Drawing.Size(137, 17);
            this.labelPesquisaPainel.TabIndex = 0;
            this.labelPesquisaPainel.Text = "Painel de Pesquisa";
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCadastro.BackgroundImage")));
            this.buttonCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCadastro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCadastro.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonCadastro.Location = new System.Drawing.Point(171, 3);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(97, 105);
            this.buttonCadastro.TabIndex = 1;
            this.buttonCadastro.Text = "CADASTRO";
            this.buttonCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastro.UseVisualStyleBackColor = false;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonSupport_Click);
            // 
            // P
            // 
            this.P.Image = ((System.Drawing.Image)(resources.GetObject("P.Image")));
            this.P.Location = new System.Drawing.Point(3, -1);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(152, 111);
            this.P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P.TabIndex = 0;
            this.P.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // menuStripTelaInicial
            // 
            this.menuStripTelaInicial.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTelaInicial.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripTelaInicial.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTelaInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadoToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStripTelaInicial.Location = new System.Drawing.Point(0, 0);
            this.menuStripTelaInicial.Name = "menuStripTelaInicial";
            this.menuStripTelaInicial.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripTelaInicial.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripTelaInicial.Size = new System.Drawing.Size(1161, 24);
            this.menuStripTelaInicial.TabIndex = 0;
            this.menuStripTelaInicial.Text = "menuStrip1";
            // 
            // chamadoToolStripMenuItem
            // 
            this.chamadoToolStripMenuItem.Name = "chamadoToolStripMenuItem";
            this.chamadoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.chamadoToolStripMenuItem.Text = "Chamado";
            this.chamadoToolStripMenuItem.Click += new System.EventHandler(this.chamadoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click_1);
            // 
            // panelTelaPrincipal
            // 
            this.panelTelaPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTelaPrincipal.Controls.Add(this.panelUser);
            this.panelTelaPrincipal.Controls.Add(this.menuStripTelaInicial);
            this.panelTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTelaPrincipal.Location = new System.Drawing.Point(0, 113);
            this.panelTelaPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelTelaPrincipal.Name = "panelTelaPrincipal";
            this.panelTelaPrincipal.Size = new System.Drawing.Size(1161, 559);
            this.panelTelaPrincipal.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.panelChamado);
            this.panelUser.Controls.Add(this.dataGridViewTabUsuarioTP);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(0, 24);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1161, 535);
            this.panelUser.TabIndex = 1;
            // 
            // panelChamado
            // 
            this.panelChamado.Controls.Add(this.dataGridViewTabChamadoTP);
            this.panelChamado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChamado.Location = new System.Drawing.Point(0, 0);
            this.panelChamado.Margin = new System.Windows.Forms.Padding(2);
            this.panelChamado.Name = "panelChamado";
            this.panelChamado.Size = new System.Drawing.Size(1161, 535);
            this.panelChamado.TabIndex = 2;
            // 
            // dataGridViewTabChamadoTP
            // 
            this.dataGridViewTabChamadoTP.AllowUserToAddRows = false;
            this.dataGridViewTabChamadoTP.AllowUserToResizeColumns = false;
            this.dataGridViewTabChamadoTP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTabChamadoTP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTabChamadoTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTabChamadoTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTabChamadoTP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTabChamadoTP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTabChamadoTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTabChamadoTP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTabChamadoTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTabChamadoTP.EnableHeadersVisualStyles = false;
            this.dataGridViewTabChamadoTP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTabChamadoTP.Name = "dataGridViewTabChamadoTP";
            this.dataGridViewTabChamadoTP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTabChamadoTP.RowHeadersVisible = false;
            this.dataGridViewTabChamadoTP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTabChamadoTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTabChamadoTP.Size = new System.Drawing.Size(1161, 535);
            this.dataGridViewTabChamadoTP.TabIndex = 3;
            this.dataGridViewTabChamadoTP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTabChamadoTP_CellFormatting);
            this.dataGridViewTabChamadoTP.DoubleClick += new System.EventHandler(this.dataGridViewTabChamadoTP_DoubleClick);
            // 
            // dataGridViewTabUsuarioTP
            // 
            this.dataGridViewTabUsuarioTP.AllowUserToAddRows = false;
            this.dataGridViewTabUsuarioTP.AllowUserToDeleteRows = false;
            this.dataGridViewTabUsuarioTP.AllowUserToResizeColumns = false;
            this.dataGridViewTabUsuarioTP.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTabUsuarioTP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTabUsuarioTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTabUsuarioTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTabUsuarioTP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTabUsuarioTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTabUsuarioTP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTabUsuarioTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTabUsuarioTP.EnableHeadersVisualStyles = false;
            this.dataGridViewTabUsuarioTP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTabUsuarioTP.Name = "dataGridViewTabUsuarioTP";
            this.dataGridViewTabUsuarioTP.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTabUsuarioTP.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTabUsuarioTP.RowHeadersVisible = false;
            this.dataGridViewTabUsuarioTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTabUsuarioTP.Size = new System.Drawing.Size(1161, 535);
            this.dataGridViewTabUsuarioTP.TabIndex = 1;
            this.dataGridViewTabUsuarioTP.DoubleClick += new System.EventHandler(this.dataGridViewTabUsuarioTP_DoubleClick);
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1161, 672);
            this.Controls.Add(this.panelTelaPrincipal);
            this.Controls.Add(this.panelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormTelaPrincipal_Activated);
            this.Load += new System.EventHandler(this.FormTelaPrincipal_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelPainel.ResumeLayout(false);
            this.panelPainel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
            this.menuStripTelaInicial.ResumeLayout(false);
            this.menuStripTelaInicial.PerformLayout();
            this.panelTelaPrincipal.ResumeLayout(false);
            this.panelTelaPrincipal.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelChamado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabChamadoTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabUsuarioTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox P;
        private System.Windows.Forms.Label labelPesquisaPainel;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Label labelDataAbertura;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechamentoTP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAberturaTP;
        private System.Windows.Forms.ComboBox comboBoxStatusTP;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeTP;
        public System.Windows.Forms.Button buttonCriaTicket;
        public System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.MenuStrip menuStripTelaInicial;
        private System.Windows.Forms.ToolStripMenuItem chamadoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Panel panelTelaPrincipal;
        private System.Windows.Forms.Panel panelUser;
        public System.Windows.Forms.DataGridView dataGridViewTabUsuarioTP;
        private System.Windows.Forms.Panel panelChamado;
        public System.Windows.Forms.DataGridView dataGridViewTabChamadoTP;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxNomeUserTelaPrin;
        public System.Windows.Forms.TextBox textBoxIdUserTelaPrin;
        public System.Windows.Forms.TextBox textBoxSetorTP;
        public System.Windows.Forms.Panel panelPainel;
        public System.Windows.Forms.Button buttonRelatorio;
    }
}