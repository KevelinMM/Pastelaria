namespace Pastelaria_do_Zé
{
    partial class Configuracoes
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
            this.labelConfigSistemasCobranca = new System.Windows.Forms.Label();
            this.labelConfigMulta = new System.Windows.Forms.Label();
            this.labelConfigPercentual = new System.Windows.Forms.Label();
            this.textBoxConfig2 = new System.Windows.Forms.TextBox();
            this.textBoxConfig1 = new System.Windows.Forms.TextBox();
            this.labelConfiguracoes = new System.Windows.Forms.Label();
            this.labelConfigIdioma = new System.Windows.Forms.Label();
            this.comboBoxConfig = new System.Windows.Forms.ComboBox();
            this.buttonConfigSalvar = new System.Windows.Forms.Button();
            this.checkBoxSelecionarIdioma = new System.Windows.Forms.CheckBox();
            this.TextBoxStringDeConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSairConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfigSistemasCobranca
            // 
            this.labelConfigSistemasCobranca.AutoSize = true;
            this.labelConfigSistemasCobranca.Location = new System.Drawing.Point(28, 80);
            this.labelConfigSistemasCobranca.Name = "labelConfigSistemasCobranca";
            this.labelConfigSistemasCobranca.Size = new System.Drawing.Size(186, 15);
            this.labelConfigSistemasCobranca.TabIndex = 37;
            this.labelConfigSistemasCobranca.Text = "Sistemas de cobranças em Atraso:";
            // 
            // labelConfigMulta
            // 
            this.labelConfigMulta.AutoSize = true;
            this.labelConfigMulta.Location = new System.Drawing.Point(215, 114);
            this.labelConfigMulta.Name = "labelConfigMulta";
            this.labelConfigMulta.Size = new System.Drawing.Size(123, 15);
            this.labelConfigMulta.TabIndex = 36;
            this.labelConfigMulta.Text = "Multa por Atraso (R$):";
            // 
            // labelConfigPercentual
            // 
            this.labelConfigPercentual.AutoSize = true;
            this.labelConfigPercentual.Location = new System.Drawing.Point(28, 114);
            this.labelConfigPercentual.Name = "labelConfigPercentual";
            this.labelConfigPercentual.Size = new System.Drawing.Size(167, 15);
            this.labelConfigPercentual.TabIndex = 35;
            this.labelConfigPercentual.Text = "Percentual Diário de Juros (%):";
            // 
            // textBoxConfig2
            // 
            this.textBoxConfig2.Location = new System.Drawing.Point(215, 132);
            this.textBoxConfig2.Name = "textBoxConfig2";
            this.textBoxConfig2.Size = new System.Drawing.Size(123, 23);
            this.textBoxConfig2.TabIndex = 2;
            // 
            // textBoxConfig1
            // 
            this.textBoxConfig1.Location = new System.Drawing.Point(28, 132);
            this.textBoxConfig1.Name = "textBoxConfig1";
            this.textBoxConfig1.Size = new System.Drawing.Size(167, 23);
            this.textBoxConfig1.TabIndex = 1;
            // 
            // labelConfiguracoes
            // 
            this.labelConfiguracoes.AutoSize = true;
            this.labelConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConfiguracoes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelConfiguracoes.Location = new System.Drawing.Point(201, 21);
            this.labelConfiguracoes.Name = "labelConfiguracoes";
            this.labelConfiguracoes.Size = new System.Drawing.Size(137, 28);
            this.labelConfiguracoes.TabIndex = 31;
            this.labelConfiguracoes.Text = "Configurações";
            // 
            // labelConfigIdioma
            // 
            this.labelConfigIdioma.AutoSize = true;
            this.labelConfigIdioma.Location = new System.Drawing.Point(367, 114);
            this.labelConfigIdioma.Name = "labelConfigIdioma";
            this.labelConfigIdioma.Size = new System.Drawing.Size(47, 15);
            this.labelConfigIdioma.TabIndex = 42;
            this.labelConfigIdioma.Text = "Idioma:";
            // 
            // comboBoxConfig
            // 
            this.comboBoxConfig.FormattingEnabled = true;
            this.comboBoxConfig.Items.AddRange(new object[] {
            "pt-BR",
            "en-US",
            "es"});
            this.comboBoxConfig.Location = new System.Drawing.Point(367, 132);
            this.comboBoxConfig.Name = "comboBoxConfig";
            this.comboBoxConfig.Size = new System.Drawing.Size(148, 23);
            this.comboBoxConfig.TabIndex = 3;
            // 
            // buttonConfigSalvar
            // 
            this.buttonConfigSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConfigSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConfigSalvar.Location = new System.Drawing.Point(415, 296);
            this.buttonConfigSalvar.Name = "buttonConfigSalvar";
            this.buttonConfigSalvar.Size = new System.Drawing.Size(100, 33);
            this.buttonConfigSalvar.TabIndex = 4;
            this.buttonConfigSalvar.Text = "Salvar";
            this.buttonConfigSalvar.UseVisualStyleBackColor = false;
            this.buttonConfigSalvar.Click += new System.EventHandler(this.ButtonConfigSalvar_Click);
            // 
            // checkBoxSelecionarIdioma
            // 
            this.checkBoxSelecionarIdioma.AutoSize = true;
            this.checkBoxSelecionarIdioma.Location = new System.Drawing.Point(435, 161);
            this.checkBoxSelecionarIdioma.Name = "checkBoxSelecionarIdioma";
            this.checkBoxSelecionarIdioma.Size = new System.Drawing.Size(80, 19);
            this.checkBoxSelecionarIdioma.TabIndex = 47;
            this.checkBoxSelecionarIdioma.Text = "Selecionar";
            this.checkBoxSelecionarIdioma.UseVisualStyleBackColor = true;
            // 
            // TextBoxStringDeConexao
            // 
            this.TextBoxStringDeConexao.Location = new System.Drawing.Point(28, 255);
            this.TextBoxStringDeConexao.Name = "TextBoxStringDeConexao";
            this.TextBoxStringDeConexao.Size = new System.Drawing.Size(344, 23);
            this.TextBoxStringDeConexao.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "String de Conexão";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(28, 198);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(344, 23);
            this.comboBoxProvider.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Provider";
            // 
            // buttonSairConfig
            // 
            this.buttonSairConfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSairConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSairConfig.Location = new System.Drawing.Point(28, 296);
            this.buttonSairConfig.Name = "buttonSairConfig";
            this.buttonSairConfig.Size = new System.Drawing.Size(100, 33);
            this.buttonSairConfig.TabIndex = 52;
            this.buttonSairConfig.Text = "Sair";
            this.buttonSairConfig.UseVisualStyleBackColor = false;
            this.buttonSairConfig.Click += new System.EventHandler(this.buttonSairConfig_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 341);
            this.Controls.Add(this.buttonSairConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxStringDeConexao);
            this.Controls.Add(this.checkBoxSelecionarIdioma);
            this.Controls.Add(this.buttonConfigSalvar);
            this.Controls.Add(this.comboBoxConfig);
            this.Controls.Add(this.labelConfigIdioma);
            this.Controls.Add(this.labelConfigSistemasCobranca);
            this.Controls.Add(this.labelConfigMulta);
            this.Controls.Add(this.labelConfigPercentual);
            this.Controls.Add(this.textBoxConfig2);
            this.Controls.Add(this.textBoxConfig1);
            this.Controls.Add(this.labelConfiguracoes);
            this.KeyPreview = true;
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuracoes_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Configuracoes_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelConfigSistemasCobranca;
        private Label labelConfigMulta;
        private Label labelConfigPercentual;
        private TextBox textBoxConfig2;
        private TextBox textBoxConfig1;
        private Label labelConfiguracoes;
        private Label labelConfigIdioma;
        private ComboBox comboBoxConfig;
        private Button buttonConfigSalvar;
        private CheckBox checkBoxSelecionarIdioma;
        private TextBox TextBoxStringDeConexao;
        private Label label1;
        private ComboBox comboBoxProvider;
        private Label label2;
        private Button buttonSairConfig;
    }
}