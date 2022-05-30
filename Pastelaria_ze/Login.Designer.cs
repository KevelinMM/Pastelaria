namespace Pastelaria_do_Zé
{
    /// <summary>
    /// 
    /// </summary>
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelLoginUsuario = new System.Windows.Forms.Label();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.textBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.buttonLoginEntrar = new System.Windows.Forms.Button();
            this.labelLoginTitulo = new System.Windows.Forms.Label();
            this.buttonLoginEsqueciSenha = new System.Windows.Forms.Button();
            this.labelAste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoginUsuario
            // 
            resources.ApplyResources(this.labelLoginUsuario, "labelLoginUsuario");
            this.labelLoginUsuario.Name = "labelLoginUsuario";
            // 
            // labelLoginSenha
            // 
            resources.ApplyResources(this.labelLoginSenha, "labelLoginSenha");
            this.labelLoginSenha.Name = "labelLoginSenha";
            // 
            // textBoxLoginUsuario
            // 
            resources.ApplyResources(this.textBoxLoginUsuario, "textBoxLoginUsuario");
            this.textBoxLoginUsuario.Name = "textBoxLoginUsuario";
            this.textBoxLoginUsuario.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBoxLoginUsuario.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // textBoxLoginSenha
            // 
            resources.ApplyResources(this.textBoxLoginSenha, "textBoxLoginSenha");
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.textBoxLoginSenha.Leave += new System.EventHandler(this.TextBox2_Leave);
            // 
            // buttonLoginEntrar
            // 
            this.buttonLoginEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.buttonLoginEntrar, "buttonLoginEntrar");
            this.buttonLoginEntrar.Name = "buttonLoginEntrar";
            this.buttonLoginEntrar.UseVisualStyleBackColor = false;
            this.buttonLoginEntrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelLoginTitulo
            // 
            resources.ApplyResources(this.labelLoginTitulo, "labelLoginTitulo");
            this.labelLoginTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelLoginTitulo.Name = "labelLoginTitulo";
            // 
            // buttonLoginEsqueciSenha
            // 
            resources.ApplyResources(this.buttonLoginEsqueciSenha, "buttonLoginEsqueciSenha");
            this.buttonLoginEsqueciSenha.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLoginEsqueciSenha.Name = "buttonLoginEsqueciSenha";
            this.buttonLoginEsqueciSenha.UseVisualStyleBackColor = false;
            this.buttonLoginEsqueciSenha.Click += new System.EventHandler(this.Button2_Click);
            // 
            // labelAste
            // 
            resources.ApplyResources(this.labelAste, "labelAste");
            this.labelAste.Name = "labelAste";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAste);
            this.Controls.Add(this.buttonLoginEsqueciSenha);
            this.Controls.Add(this.labelLoginTitulo);
            this.Controls.Add(this.buttonLoginEntrar);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.textBoxLoginUsuario);
            this.Controls.Add(this.labelLoginSenha);
            this.Controls.Add(this.labelLoginUsuario);
            this.KeyPreview = true;
            this.Name = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLoginUsuario;
        private Label labelLoginSenha;
        private TextBox textBoxLoginUsuario;
        private TextBox textBoxLoginSenha;
        private Button buttonLoginEntrar;
        private Label labelLoginTitulo;
        private Button buttonLoginEsqueciSenha;
        private Label labelAste;
        private Label label1;
    }
}