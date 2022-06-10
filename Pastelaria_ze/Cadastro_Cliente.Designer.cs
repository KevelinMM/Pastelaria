namespace Pastelaria_do_Zé
{
    partial class Cadastro_Cliente
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
            this.labelClienteReSenha = new System.Windows.Forms.Label();
            this.labelClienteSenha = new System.Windows.Forms.Label();
            this.labelClienteContato = new System.Windows.Forms.Label();
            this.labelClienteDescricao = new System.Windows.Forms.Label();
            this.labelClienteNome = new System.Windows.Forms.Label();
            this.labelClienteID = new System.Windows.Forms.Label();
            this.textBoxClienteRe = new System.Windows.Forms.TextBox();
            this.textBoxClienteSenha = new System.Windows.Forms.TextBox();
            this.textBoxClienteNome = new System.Windows.Forms.TextBox();
            this.labelClienteCadastro = new System.Windows.Forms.Label();
            this.labelClienteFiado = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.numericUpDownDiaFiado = new System.Windows.Forms.NumericUpDown();
            this.salvar_VoltarCliente = new Pastelaria_do_Zé.Salvar_Voltar();
            this.maskedTextBoxContato = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxFiado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaFiado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClienteReSenha
            // 
            this.labelClienteReSenha.AutoSize = true;
            this.labelClienteReSenha.Location = new System.Drawing.Point(242, 312);
            this.labelClienteReSenha.Name = "labelClienteReSenha";
            this.labelClienteReSenha.Size = new System.Drawing.Size(60, 15);
            this.labelClienteReSenha.TabIndex = 33;
            this.labelClienteReSenha.Text = "Re-Senha:";
            // 
            // labelClienteSenha
            // 
            this.labelClienteSenha.AutoSize = true;
            this.labelClienteSenha.Location = new System.Drawing.Point(60, 312);
            this.labelClienteSenha.Name = "labelClienteSenha";
            this.labelClienteSenha.Size = new System.Drawing.Size(42, 15);
            this.labelClienteSenha.TabIndex = 32;
            this.labelClienteSenha.Text = "Senha:";
            // 
            // labelClienteContato
            // 
            this.labelClienteContato.AutoSize = true;
            this.labelClienteContato.Location = new System.Drawing.Point(59, 251);
            this.labelClienteContato.Name = "labelClienteContato";
            this.labelClienteContato.Size = new System.Drawing.Size(53, 15);
            this.labelClienteContato.TabIndex = 31;
            this.labelClienteContato.Text = "Contato:";
            // 
            // labelClienteDescricao
            // 
            this.labelClienteDescricao.AutoSize = true;
            this.labelClienteDescricao.Location = new System.Drawing.Point(61, 189);
            this.labelClienteDescricao.Name = "labelClienteDescricao";
            this.labelClienteDescricao.Size = new System.Drawing.Size(31, 15);
            this.labelClienteDescricao.TabIndex = 30;
            this.labelClienteDescricao.Text = "CPF:";
            // 
            // labelClienteNome
            // 
            this.labelClienteNome.AutoSize = true;
            this.labelClienteNome.Location = new System.Drawing.Point(62, 135);
            this.labelClienteNome.Name = "labelClienteNome";
            this.labelClienteNome.Size = new System.Drawing.Size(43, 15);
            this.labelClienteNome.TabIndex = 28;
            this.labelClienteNome.Text = "Nome:";
            // 
            // labelClienteID
            // 
            this.labelClienteID.AutoSize = true;
            this.labelClienteID.Location = new System.Drawing.Point(60, 80);
            this.labelClienteID.Name = "labelClienteID";
            this.labelClienteID.Size = new System.Drawing.Size(21, 15);
            this.labelClienteID.TabIndex = 27;
            this.labelClienteID.Text = "ID:";
            // 
            // textBoxClienteRe
            // 
            this.textBoxClienteRe.Location = new System.Drawing.Point(242, 330);
            this.textBoxClienteRe.Name = "textBoxClienteRe";
            this.textBoxClienteRe.PasswordChar = '*';
            this.textBoxClienteRe.Size = new System.Drawing.Size(132, 23);
            this.textBoxClienteRe.TabIndex = 7;
            // 
            // textBoxClienteSenha
            // 
            this.textBoxClienteSenha.Location = new System.Drawing.Point(59, 330);
            this.textBoxClienteSenha.Name = "textBoxClienteSenha";
            this.textBoxClienteSenha.PasswordChar = '*';
            this.textBoxClienteSenha.Size = new System.Drawing.Size(143, 23);
            this.textBoxClienteSenha.TabIndex = 6;
            // 
            // textBoxClienteNome
            // 
            this.textBoxClienteNome.Location = new System.Drawing.Point(62, 153);
            this.textBoxClienteNome.Name = "textBoxClienteNome";
            this.textBoxClienteNome.Size = new System.Drawing.Size(312, 23);
            this.textBoxClienteNome.TabIndex = 2;
            // 
            // labelClienteCadastro
            // 
            this.labelClienteCadastro.AutoSize = true;
            this.labelClienteCadastro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClienteCadastro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelClienteCadastro.Location = new System.Drawing.Point(265, 21);
            this.labelClienteCadastro.Name = "labelClienteCadastro";
            this.labelClienteCadastro.Size = new System.Drawing.Size(155, 28);
            this.labelClienteCadastro.TabIndex = 17;
            this.labelClienteCadastro.Text = "Cadastro Cliente";
            // 
            // labelClienteFiado
            // 
            this.labelClienteFiado.AutoSize = true;
            this.labelClienteFiado.Location = new System.Drawing.Point(241, 251);
            this.labelClienteFiado.Name = "labelClienteFiado";
            this.labelClienteFiado.Size = new System.Drawing.Size(59, 15);
            this.labelClienteFiado.TabIndex = 35;
            this.labelClienteFiado.Text = "Dia Fiado:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 429);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // numericUpDownDiaFiado
            // 
            this.numericUpDownDiaFiado.Location = new System.Drawing.Point(241, 270);
            this.numericUpDownDiaFiado.Name = "numericUpDownDiaFiado";
            this.numericUpDownDiaFiado.Size = new System.Drawing.Size(133, 23);
            this.numericUpDownDiaFiado.TabIndex = 5;
            // 
            // salvar_VoltarCliente
            // 
            this.salvar_VoltarCliente.Location = new System.Drawing.Point(57, 359);
            this.salvar_VoltarCliente.Name = "salvar_VoltarCliente";
            this.salvar_VoltarCliente.Size = new System.Drawing.Size(583, 64);
            this.salvar_VoltarCliente.TabIndex = 8;
            // 
            // maskedTextBoxContato
            // 
            this.maskedTextBoxContato.Location = new System.Drawing.Point(60, 270);
            this.maskedTextBoxContato.Mask = "(00) 9000-0000";
            this.maskedTextBoxContato.Name = "maskedTextBoxContato";
            this.maskedTextBoxContato.Size = new System.Drawing.Size(142, 23);
            this.maskedTextBoxContato.TabIndex = 38;
            this.maskedTextBoxContato.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(62, 98);
            this.maskedTextBoxID.Mask = "0000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(140, 23);
            this.maskedTextBoxID.TabIndex = 52;
            this.maskedTextBoxID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxID.ValidatingType = typeof(int);
            // 
            // checkBoxFiado
            // 
            this.checkBoxFiado.AutoSize = true;
            this.checkBoxFiado.Location = new System.Drawing.Point(244, 207);
            this.checkBoxFiado.Name = "checkBoxFiado";
            this.checkBoxFiado.Size = new System.Drawing.Size(55, 19);
            this.checkBoxFiado.TabIndex = 53;
            this.checkBoxFiado.Text = "Fiado";
            this.checkBoxFiado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(188, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(360, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(188, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(360, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "*";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(62, 207);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(140, 23);
            this.maskedTextBoxCPF.TabIndex = 58;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDados.Location = new System.Drawing.Point(394, 111);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(257, 242);
            this.dataGridViewDados.TabIndex = 68;
            this.dataGridViewDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDados_CellContentDoubleClick);
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.Location = new System.Drawing.Point(439, 82);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirCliente.TabIndex = 70;
            this.buttonExcluirCliente.Text = "Excluir";
            this.buttonExcluirCliente.UseVisualStyleBackColor = true;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.ButtonExcluirCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.Location = new System.Drawing.Point(531, 82);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarCliente.TabIndex = 71;
            this.buttonEditarCliente.Text = "Editar";
            this.buttonEditarCliente.UseVisualStyleBackColor = true;
            this.buttonEditarCliente.Click += new System.EventHandler(this.ButtonEditarCliente_Click);
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 429);
            this.Controls.Add(this.buttonEditarCliente);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxFiado);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(this.maskedTextBoxContato);
            this.Controls.Add(this.salvar_VoltarCliente);
            this.Controls.Add(this.numericUpDownDiaFiado);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelClienteFiado);
            this.Controls.Add(this.labelClienteReSenha);
            this.Controls.Add(this.labelClienteSenha);
            this.Controls.Add(this.labelClienteContato);
            this.Controls.Add(this.labelClienteDescricao);
            this.Controls.Add(this.labelClienteNome);
            this.Controls.Add(this.labelClienteID);
            this.Controls.Add(this.textBoxClienteRe);
            this.Controls.Add(this.textBoxClienteSenha);
            this.Controls.Add(this.textBoxClienteNome);
            this.Controls.Add(this.labelClienteCadastro);
            this.KeyPreview = true;
            this.Name = "Cadastro_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Cliente_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastro_Cliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaFiado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelClienteReSenha;
        private Label labelClienteSenha;
        private Label labelClienteContato;
        private Label labelClienteDescricao;
        private Label labelClienteNome;
        private Label labelClienteID;
        private TextBox textBoxClienteRe;
        private TextBox textBoxClienteSenha;
        private TextBox textBoxClienteNome;
        private Label labelClienteCadastro;
        private Label labelClienteFiado;
        private Splitter splitter1;
        private NumericUpDown numericUpDownDiaFiado;
        private Salvar_Voltar salvar_VoltarCliente;
        private MaskedTextBox maskedTextBoxContato;
        private MaskedTextBox maskedTextBoxID;
        private CheckBox checkBoxFiado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBoxCPF;
        private DataGridView dataGridViewDados;
        private Button buttonExcluirCliente;
        private Button buttonEditarCliente;
    }
}