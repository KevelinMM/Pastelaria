namespace Pastelaria_do_Zé
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStripPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.txtClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMenuFuncionarios = new System.Windows.Forms.Button();
            this.labelMenuClientes = new System.Windows.Forms.Button();
            this.labelMenuProdutos = new System.Windows.Forms.Button();
            this.labelMenuNomeFuncionario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMenuCadastrar = new System.Windows.Forms.Label();
            this.Matricula = new System.Windows.Forms.PictureBox();
            this.buttonCadastrados = new System.Windows.Forms.Button();
            this.buttonSairMenu = new System.Windows.Forms.Button();
            this.labelMenuSobre = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelMenuConfig = new System.Windows.Forms.Button();
            this.labelMenuInicio = new System.Windows.Forms.Label();
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMenuCadastrarComanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.ContextMenuStrip = this.contextMenuStripPrincipal;
            this.splitContainer1.Panel1.Controls.Add(this.buttonMenuCadastrarComanda);
            this.splitContainer1.Panel1.Controls.Add(this.labelMenuFuncionarios);
            this.splitContainer1.Panel1.Controls.Add(this.labelMenuClientes);
            this.splitContainer1.Panel1.Controls.Add(this.labelMenuProdutos);
            this.splitContainer1.Panel1.Controls.Add(this.labelMenuNomeFuncionario);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.labelMenuCadastrar);
            this.splitContainer1.Panel1.Controls.Add(this.Matricula);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.buttonCadastrados);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSairMenu);
            this.splitContainer1.Panel2.Controls.Add(this.labelMenuSobre);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.labelMenuConfig);
            this.splitContainer1.Panel2.Controls.Add(this.labelMenuInicio);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxInicio);
            this.splitContainer1.Size = new System.Drawing.Size(633, 366);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // contextMenuStripPrincipal
            // 
            this.contextMenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtProdutos,
            this.txtClientes,
            this.txtFuncionarios,
            this.txtConfig,
            this.txtSobre,
            this.sairToolStripMenuItem});
            this.contextMenuStripPrincipal.Name = "contextMenuStrip1";
            this.contextMenuStripPrincipal.Size = new System.Drawing.Size(203, 136);
            // 
            // txtProdutos
            // 
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.txtProdutos.Size = new System.Drawing.Size(202, 22);
            this.txtProdutos.Text = "Produtos";
            this.txtProdutos.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // txtClientes
            // 
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.txtClientes.Size = new System.Drawing.Size(202, 22);
            this.txtClientes.Text = "Clientes";
            this.txtClientes.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // txtFuncionarios
            // 
            this.txtFuncionarios.Name = "txtFuncionarios";
            this.txtFuncionarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.txtFuncionarios.Size = new System.Drawing.Size(202, 22);
            this.txtFuncionarios.Text = "Funcionários";
            this.txtFuncionarios.Click += new System.EventHandler(this.FuncionariosToolStripMenuItem_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
            this.txtConfig.Size = new System.Drawing.Size(202, 22);
            this.txtConfig.Text = "Configurações";
            this.txtConfig.Click += new System.EventHandler(this.ConfiguraçõesToolStripMenuItem_Click);
            // 
            // txtSobre
            // 
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F8)));
            this.txtSobre.Size = new System.Drawing.Size(202, 22);
            this.txtSobre.Text = "Sobre";
            this.txtSobre.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // labelMenuFuncionarios
            // 
            this.labelMenuFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMenuFuncionarios.Location = new System.Drawing.Point(27, 311);
            this.labelMenuFuncionarios.Name = "labelMenuFuncionarios";
            this.labelMenuFuncionarios.Size = new System.Drawing.Size(91, 23);
            this.labelMenuFuncionarios.TabIndex = 6;
            this.labelMenuFuncionarios.Text = "Funcionários";
            this.labelMenuFuncionarios.UseVisualStyleBackColor = false;
            this.labelMenuFuncionarios.Click += new System.EventHandler(this.Funcionarios_Click);
            // 
            // labelMenuClientes
            // 
            this.labelMenuClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMenuClientes.Location = new System.Drawing.Point(27, 271);
            this.labelMenuClientes.Name = "labelMenuClientes";
            this.labelMenuClientes.Size = new System.Drawing.Size(91, 23);
            this.labelMenuClientes.TabIndex = 5;
            this.labelMenuClientes.Text = "Clientes";
            this.labelMenuClientes.UseVisualStyleBackColor = false;
            this.labelMenuClientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // labelMenuProdutos
            // 
            this.labelMenuProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMenuProdutos.Location = new System.Drawing.Point(27, 230);
            this.labelMenuProdutos.Name = "labelMenuProdutos";
            this.labelMenuProdutos.Size = new System.Drawing.Size(91, 23);
            this.labelMenuProdutos.TabIndex = 4;
            this.labelMenuProdutos.Text = "Produtos";
            this.labelMenuProdutos.UseVisualStyleBackColor = false;
            this.labelMenuProdutos.Click += new System.EventHandler(this.Produto_Click);
            // 
            // labelMenuNomeFuncionario
            // 
            this.labelMenuNomeFuncionario.AutoSize = true;
            this.labelMenuNomeFuncionario.Location = new System.Drawing.Point(39, 102);
            this.labelMenuNomeFuncionario.Name = "labelMenuNomeFuncionario";
            this.labelMenuNomeFuncionario.Size = new System.Drawing.Size(106, 15);
            this.labelMenuNomeFuncionario.TabIndex = 6;
            this.labelMenuNomeFuncionario.Text = "Nome Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // labelMenuCadastrar
            // 
            this.labelMenuCadastrar.AutoSize = true;
            this.labelMenuCadastrar.Location = new System.Drawing.Point(27, 161);
            this.labelMenuCadastrar.Name = "labelMenuCadastrar";
            this.labelMenuCadastrar.Size = new System.Drawing.Size(60, 15);
            this.labelMenuCadastrar.TabIndex = 2;
            this.labelMenuCadastrar.Text = "Cadastrar:";
            // 
            // Matricula
            // 
            this.Matricula.BackgroundImage = global::Pastelaria_do_Zé.Properties.Resources.cracha;
            this.Matricula.Image = global::Pastelaria_do_Zé.Properties.Resources.cracha;
            this.Matricula.Location = new System.Drawing.Point(51, 27);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(79, 72);
            this.Matricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Matricula.TabIndex = 0;
            this.Matricula.TabStop = false;
            // 
            // buttonCadastrados
            // 
            this.buttonCadastrados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCadastrados.Location = new System.Drawing.Point(162, 302);
            this.buttonCadastrados.Name = "buttonCadastrados";
            this.buttonCadastrados.Size = new System.Drawing.Size(123, 41);
            this.buttonCadastrados.TabIndex = 12;
            this.buttonCadastrados.Text = "Cadastrados";
            this.buttonCadastrados.UseVisualStyleBackColor = false;
            this.buttonCadastrados.Click += new System.EventHandler(this.ButtonCadastrados_Click);
            // 
            // buttonSairMenu
            // 
            this.buttonSairMenu.BackColor = System.Drawing.Color.Bisque;
            this.buttonSairMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSairMenu.Location = new System.Drawing.Point(387, 306);
            this.buttonSairMenu.Name = "buttonSairMenu";
            this.buttonSairMenu.Size = new System.Drawing.Size(55, 33);
            this.buttonSairMenu.TabIndex = 11;
            this.buttonSairMenu.Text = "Sair";
            this.buttonSairMenu.UseVisualStyleBackColor = false;
            this.buttonSairMenu.Click += new System.EventHandler(this.ButtonSairMenu_Click);
            // 
            // labelMenuSobre
            // 
            this.labelMenuSobre.Location = new System.Drawing.Point(387, 21);
            this.labelMenuSobre.Name = "labelMenuSobre";
            this.labelMenuSobre.Size = new System.Drawing.Size(55, 23);
            this.labelMenuSobre.TabIndex = 3;
            this.labelMenuSobre.Text = "Sobre";
            this.labelMenuSobre.UseVisualStyleBackColor = true;
            this.labelMenuSobre.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(229, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // labelMenuConfig
            // 
            this.labelMenuConfig.Location = new System.Drawing.Point(326, 21);
            this.labelMenuConfig.Name = "labelMenuConfig";
            this.labelMenuConfig.Size = new System.Drawing.Size(55, 23);
            this.labelMenuConfig.TabIndex = 2;
            this.labelMenuConfig.Text = "Configurações";
            this.labelMenuConfig.UseVisualStyleBackColor = true;
            this.labelMenuConfig.Click += new System.EventHandler(this.Button2_Click);
            // 
            // labelMenuInicio
            // 
            this.labelMenuInicio.AutoSize = true;
            this.labelMenuInicio.Location = new System.Drawing.Point(54, 29);
            this.labelMenuInicio.Name = "labelMenuInicio";
            this.labelMenuInicio.Size = new System.Drawing.Size(36, 15);
            this.labelMenuInicio.TabIndex = 7;
            this.labelMenuInicio.Text = "Início";
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.Location = new System.Drawing.Point(96, 24);
            this.textBoxInicio.Multiline = true;
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(138, 24);
            this.textBoxInicio.TabIndex = 1;
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconSystemTray.BalloonTipText = "Pastelaria do Zé";
            this.notifyIconSystemTray.BalloonTipTitle = "Aplicação continua rodando";
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "Pastelaria Do zé";
            this.notifyIconSystemTray.DoubleClick += new System.EventHandler(this.NotifyIconSystemTray_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem1,
            this.sobreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 70);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.SairToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click_1);
            // 
            // buttonMenuCadastrarComanda
            // 
            this.buttonMenuCadastrarComanda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenuCadastrarComanda.Location = new System.Drawing.Point(27, 188);
            this.buttonMenuCadastrarComanda.Name = "buttonMenuCadastrarComanda";
            this.buttonMenuCadastrarComanda.Size = new System.Drawing.Size(91, 23);
            this.buttonMenuCadastrarComanda.TabIndex = 7;
            this.buttonMenuCadastrarComanda.Text = "Comanda";
            this.buttonMenuCadastrarComanda.UseVisualStyleBackColor = false;
            this.buttonMenuCadastrarComanda.Click += new System.EventHandler(this.ButtonMenuCadastrarComanda_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 366);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Matricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox Matricula;
        private Label label4;
        private Label label3;
        private Label labelMenuCadastrar;
        private Label labelMenuNomeFuncionario;
        private Label labelMenuInicio;
        private TextBox textBoxInicio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox3;
        private Button labelMenuConfig;
        private Button labelMenuSobre;
        private Button labelMenuProdutos;
        private Button labelMenuFuncionarios;
        private Button labelMenuClientes;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem txtProdutos;
        private ToolStripMenuItem txtClientes;
        private ToolStripMenuItem txtFuncionarios;
        private ToolStripMenuItem txtConfig;
        private ToolStripMenuItem txtSobre;
        private Button buttonSairMenu;
        private ToolStripMenuItem sairToolStripMenuItem;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button buttonCadastrados;
        private Button buttonMenuCadastrarComanda;
    }
}