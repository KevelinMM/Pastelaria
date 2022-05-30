namespace Pastelaria_do_Zé
{
    /// <summary>
    /// 
    /// </summary>
    partial class Recuperarsenha
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
            this.labelRecuperaNomeFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRecuperaInformeEmail = new System.Windows.Forms.Label();
            this.textBoxReEmail = new System.Windows.Forms.TextBox();
            this.buttonRecuperaSalvar = new System.Windows.Forms.Button();
            this.textBoxReSenha = new System.Windows.Forms.TextBox();
            this.labelRecuperaNovaSenha = new System.Windows.Forms.Label();
            this.textBoxReConfirma = new System.Windows.Forms.TextBox();
            this.labelRecuperaConfirmacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRecuperaNomeFuncionario
            // 
            this.labelRecuperaNomeFuncionario.AutoSize = true;
            this.labelRecuperaNomeFuncionario.Location = new System.Drawing.Point(202, 97);
            this.labelRecuperaNomeFuncionario.Name = "labelRecuperaNomeFuncionario";
            this.labelRecuperaNomeFuncionario.Size = new System.Drawing.Size(123, 15);
            this.labelRecuperaNomeFuncionario.TabIndex = 8;
            this.labelRecuperaNomeFuncionario.Text = "Nome do Funcionario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pastelaria_do_Zé.Properties.Resources.cracha;
            this.pictureBox1.Image = global::Pastelaria_do_Zé.Properties.Resources.cracha;
            this.pictureBox1.Location = new System.Drawing.Point(225, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelRecuperaInformeEmail
            // 
            this.labelRecuperaInformeEmail.AutoSize = true;
            this.labelRecuperaInformeEmail.Location = new System.Drawing.Point(148, 132);
            this.labelRecuperaInformeEmail.Name = "labelRecuperaInformeEmail";
            this.labelRecuperaInformeEmail.Size = new System.Drawing.Size(105, 15);
            this.labelRecuperaInformeEmail.TabIndex = 9;
            this.labelRecuperaInformeEmail.Text = "Informe seu Email ";
            // 
            // textBoxReEmail
            // 
            this.textBoxReEmail.Location = new System.Drawing.Point(148, 150);
            this.textBoxReEmail.Multiline = true;
            this.textBoxReEmail.Name = "textBoxReEmail";
            this.textBoxReEmail.Size = new System.Drawing.Size(210, 24);
            this.textBoxReEmail.TabIndex = 1;
            // 
            // buttonRecuperaSalvar
            // 
            this.buttonRecuperaSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRecuperaSalvar.Location = new System.Drawing.Point(425, 283);
            this.buttonRecuperaSalvar.Name = "buttonRecuperaSalvar";
            this.buttonRecuperaSalvar.Size = new System.Drawing.Size(85, 36);
            this.buttonRecuperaSalvar.TabIndex = 4;
            this.buttonRecuperaSalvar.Text = "SALVAR";
            this.buttonRecuperaSalvar.UseVisualStyleBackColor = false;
            this.buttonRecuperaSalvar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxReSenha
            // 
            this.textBoxReSenha.Location = new System.Drawing.Point(148, 202);
            this.textBoxReSenha.Multiline = true;
            this.textBoxReSenha.Name = "textBoxReSenha";
            this.textBoxReSenha.Size = new System.Drawing.Size(210, 24);
            this.textBoxReSenha.TabIndex = 2;
            // 
            // labelRecuperaNovaSenha
            // 
            this.labelRecuperaNovaSenha.AutoSize = true;
            this.labelRecuperaNovaSenha.Location = new System.Drawing.Point(148, 184);
            this.labelRecuperaNovaSenha.Name = "labelRecuperaNovaSenha";
            this.labelRecuperaNovaSenha.Size = new System.Drawing.Size(78, 15);
            this.labelRecuperaNovaSenha.TabIndex = 47;
            this.labelRecuperaNovaSenha.Text = "Nova Senha *";
            // 
            // textBoxReConfirma
            // 
            this.textBoxReConfirma.Location = new System.Drawing.Point(148, 257);
            this.textBoxReConfirma.Multiline = true;
            this.textBoxReConfirma.Name = "textBoxReConfirma";
            this.textBoxReConfirma.Size = new System.Drawing.Size(210, 24);
            this.textBoxReConfirma.TabIndex = 3;
            // 
            // labelRecuperaConfirmacao
            // 
            this.labelRecuperaConfirmacao.AutoSize = true;
            this.labelRecuperaConfirmacao.Location = new System.Drawing.Point(148, 239);
            this.labelRecuperaConfirmacao.Name = "labelRecuperaConfirmacao";
            this.labelRecuperaConfirmacao.Size = new System.Drawing.Size(84, 15);
            this.labelRecuperaConfirmacao.TabIndex = 49;
            this.labelRecuperaConfirmacao.Text = "Confirmação *";
            // 
            // Recuperarsenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 331);
            this.Controls.Add(this.textBoxReConfirma);
            this.Controls.Add(this.labelRecuperaConfirmacao);
            this.Controls.Add(this.textBoxReSenha);
            this.Controls.Add(this.labelRecuperaNovaSenha);
            this.Controls.Add(this.buttonRecuperaSalvar);
            this.Controls.Add(this.textBoxReEmail);
            this.Controls.Add(this.labelRecuperaInformeEmail);
            this.Controls.Add(this.labelRecuperaNomeFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Recuperarsenha";
            this.Text = "Recuperar senha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recuperarsenha_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRecuperaNomeFuncionario;
        private PictureBox pictureBox1;
        private Label labelRecuperaInformeEmail;
        private TextBox textBoxReEmail;
        private Button buttonRecuperaSalvar;
        private TextBox textBoxReSenha;
        private Label labelRecuperaNovaSenha;
        private TextBox textBoxReConfirma;
        private Label labelRecuperaConfirmacao;
    }
}