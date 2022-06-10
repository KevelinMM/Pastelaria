namespace Pastelaria_do_Zé
{
    partial class Cadastro_Funcionario
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
            this.labelFuncionarioCadastro = new System.Windows.Forms.Label();
            this.textBoxFuncionarioNome = new System.Windows.Forms.TextBox();
            this.textBoxFuncionarioSenha = new System.Windows.Forms.TextBox();
            this.textBoxFuncionarioRe = new System.Windows.Forms.TextBox();
            this.radioButtonFuncionarioAdm = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionarioBalcao = new System.Windows.Forms.RadioButton();
            this.labelFuncionarioID = new System.Windows.Forms.Label();
            this.labelFuncionarioCPF = new System.Windows.Forms.Label();
            this.labelFuncionarioMatricula = new System.Windows.Forms.Label();
            this.labelFuncionarioNomeCompleto = new System.Windows.Forms.Label();
            this.labelFuncionarioContato = new System.Windows.Forms.Label();
            this.labelFuncionarioSenha = new System.Windows.Forms.Label();
            this.labelFuncionarioReSenha = new System.Windows.Forms.Label();
            this.labelFuncionarioEmail = new System.Windows.Forms.Label();
            this.textBoxFuncionarioEmail = new System.Windows.Forms.TextBox();
            this.salvar_VoltarFuncionario = new Pastelaria_do_Zé.Salvar_Voltar();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxContato = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.buttonExcluirFuncionario = new System.Windows.Forms.Button();
            this.buttonEditarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFuncionarioCadastro
            // 
            this.labelFuncionarioCadastro.AutoSize = true;
            this.labelFuncionarioCadastro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFuncionarioCadastro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelFuncionarioCadastro.Location = new System.Drawing.Point(243, 18);
            this.labelFuncionarioCadastro.Name = "labelFuncionarioCadastro";
            this.labelFuncionarioCadastro.Size = new System.Drawing.Size(206, 28);
            this.labelFuncionarioCadastro.TabIndex = 0;
            this.labelFuncionarioCadastro.Text = "Cadastro Funcionários";
            // 
            // textBoxFuncionarioNome
            // 
            this.textBoxFuncionarioNome.Location = new System.Drawing.Point(54, 150);
            this.textBoxFuncionarioNome.Name = "textBoxFuncionarioNome";
            this.textBoxFuncionarioNome.Size = new System.Drawing.Size(353, 23);
            this.textBoxFuncionarioNome.TabIndex = 4;
            // 
            // textBoxFuncionarioSenha
            // 
            this.textBoxFuncionarioSenha.Location = new System.Drawing.Point(54, 325);
            this.textBoxFuncionarioSenha.Name = "textBoxFuncionarioSenha";
            this.textBoxFuncionarioSenha.PasswordChar = '*';
            this.textBoxFuncionarioSenha.Size = new System.Drawing.Size(156, 23);
            this.textBoxFuncionarioSenha.TabIndex = 7;
            // 
            // textBoxFuncionarioRe
            // 
            this.textBoxFuncionarioRe.Location = new System.Drawing.Point(244, 325);
            this.textBoxFuncionarioRe.Name = "textBoxFuncionarioRe";
            this.textBoxFuncionarioRe.PasswordChar = '*';
            this.textBoxFuncionarioRe.Size = new System.Drawing.Size(163, 23);
            this.textBoxFuncionarioRe.TabIndex = 8;
            // 
            // radioButtonFuncionarioAdm
            // 
            this.radioButtonFuncionarioAdm.AutoSize = true;
            this.radioButtonFuncionarioAdm.Location = new System.Drawing.Point(219, 261);
            this.radioButtonFuncionarioAdm.Name = "radioButtonFuncionarioAdm";
            this.radioButtonFuncionarioAdm.Size = new System.Drawing.Size(101, 19);
            this.radioButtonFuncionarioAdm.TabIndex = 8;
            this.radioButtonFuncionarioAdm.TabStop = true;
            this.radioButtonFuncionarioAdm.Text = "Administrador";
            this.radioButtonFuncionarioAdm.UseVisualStyleBackColor = true;
            // 
            // radioButtonFuncionarioBalcao
            // 
            this.radioButtonFuncionarioBalcao.AutoSize = true;
            this.radioButtonFuncionarioBalcao.Location = new System.Drawing.Point(341, 261);
            this.radioButtonFuncionarioBalcao.Name = "radioButtonFuncionarioBalcao";
            this.radioButtonFuncionarioBalcao.Size = new System.Drawing.Size(60, 19);
            this.radioButtonFuncionarioBalcao.TabIndex = 9;
            this.radioButtonFuncionarioBalcao.TabStop = true;
            this.radioButtonFuncionarioBalcao.Text = "Balcão";
            this.radioButtonFuncionarioBalcao.UseVisualStyleBackColor = true;
            // 
            // labelFuncionarioID
            // 
            this.labelFuncionarioID.AutoSize = true;
            this.labelFuncionarioID.Location = new System.Drawing.Point(54, 73);
            this.labelFuncionarioID.Name = "labelFuncionarioID";
            this.labelFuncionarioID.Size = new System.Drawing.Size(21, 15);
            this.labelFuncionarioID.TabIndex = 10;
            this.labelFuncionarioID.Text = "ID:";
            // 
            // labelFuncionarioCPF
            // 
            this.labelFuncionarioCPF.AutoSize = true;
            this.labelFuncionarioCPF.Location = new System.Drawing.Point(182, 73);
            this.labelFuncionarioCPF.Name = "labelFuncionarioCPF";
            this.labelFuncionarioCPF.Size = new System.Drawing.Size(31, 15);
            this.labelFuncionarioCPF.TabIndex = 11;
            this.labelFuncionarioCPF.Text = "CPF:";
            // 
            // labelFuncionarioMatricula
            // 
            this.labelFuncionarioMatricula.AutoSize = true;
            this.labelFuncionarioMatricula.Location = new System.Drawing.Point(307, 73);
            this.labelFuncionarioMatricula.Name = "labelFuncionarioMatricula";
            this.labelFuncionarioMatricula.Size = new System.Drawing.Size(60, 15);
            this.labelFuncionarioMatricula.TabIndex = 12;
            this.labelFuncionarioMatricula.Text = "Matrícula:";
            // 
            // labelFuncionarioNomeCompleto
            // 
            this.labelFuncionarioNomeCompleto.AutoSize = true;
            this.labelFuncionarioNomeCompleto.Location = new System.Drawing.Point(55, 132);
            this.labelFuncionarioNomeCompleto.Name = "labelFuncionarioNomeCompleto";
            this.labelFuncionarioNomeCompleto.Size = new System.Drawing.Size(99, 15);
            this.labelFuncionarioNomeCompleto.TabIndex = 13;
            this.labelFuncionarioNomeCompleto.Text = "Nome Completo:";
            // 
            // labelFuncionarioContato
            // 
            this.labelFuncionarioContato.AutoSize = true;
            this.labelFuncionarioContato.Location = new System.Drawing.Point(54, 242);
            this.labelFuncionarioContato.Name = "labelFuncionarioContato";
            this.labelFuncionarioContato.Size = new System.Drawing.Size(53, 15);
            this.labelFuncionarioContato.TabIndex = 14;
            this.labelFuncionarioContato.Text = "Contato:";
            // 
            // labelFuncionarioSenha
            // 
            this.labelFuncionarioSenha.AutoSize = true;
            this.labelFuncionarioSenha.Location = new System.Drawing.Point(55, 307);
            this.labelFuncionarioSenha.Name = "labelFuncionarioSenha";
            this.labelFuncionarioSenha.Size = new System.Drawing.Size(42, 15);
            this.labelFuncionarioSenha.TabIndex = 15;
            this.labelFuncionarioSenha.Text = "Senha:";
            // 
            // labelFuncionarioReSenha
            // 
            this.labelFuncionarioReSenha.AutoSize = true;
            this.labelFuncionarioReSenha.Location = new System.Drawing.Point(244, 307);
            this.labelFuncionarioReSenha.Name = "labelFuncionarioReSenha";
            this.labelFuncionarioReSenha.Size = new System.Drawing.Size(60, 15);
            this.labelFuncionarioReSenha.TabIndex = 16;
            this.labelFuncionarioReSenha.Text = "Re-Senha:";
            // 
            // labelFuncionarioEmail
            // 
            this.labelFuncionarioEmail.AutoSize = true;
            this.labelFuncionarioEmail.Location = new System.Drawing.Point(55, 189);
            this.labelFuncionarioEmail.Name = "labelFuncionarioEmail";
            this.labelFuncionarioEmail.Size = new System.Drawing.Size(39, 15);
            this.labelFuncionarioEmail.TabIndex = 48;
            this.labelFuncionarioEmail.Text = "Email:";
            // 
            // textBoxFuncionarioEmail
            // 
            this.textBoxFuncionarioEmail.Location = new System.Drawing.Point(54, 207);
            this.textBoxFuncionarioEmail.Name = "textBoxFuncionarioEmail";
            this.textBoxFuncionarioEmail.Size = new System.Drawing.Size(352, 23);
            this.textBoxFuncionarioEmail.TabIndex = 5;
            // 
            // salvar_VoltarFuncionario
            // 
            this.salvar_VoltarFuncionario.Location = new System.Drawing.Point(45, 363);
            this.salvar_VoltarFuncionario.Name = "salvar_VoltarFuncionario";
            this.salvar_VoltarFuncionario.Size = new System.Drawing.Size(592, 64);
            this.salvar_VoltarFuncionario.TabIndex = 9;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(182, 91);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxCPF.TabIndex = 50;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxMatricula
            // 
            this.maskedTextBoxMatricula.Location = new System.Drawing.Point(307, 91);
            this.maskedTextBoxMatricula.Mask = "00000";
            this.maskedTextBoxMatricula.Name = "maskedTextBoxMatricula";
            this.maskedTextBoxMatricula.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxMatricula.TabIndex = 51;
            this.maskedTextBoxMatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxMatricula.ValidatingType = typeof(int);
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.Location = new System.Drawing.Point(54, 91);
            this.maskedTextBoxId.Mask = "0000";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxId.TabIndex = 53;
            this.maskedTextBoxId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxId.ValidatingType = typeof(int);
            // 
            // maskedTextBoxContato
            // 
            this.maskedTextBoxContato.Location = new System.Drawing.Point(55, 260);
            this.maskedTextBoxContato.Mask = "(00) 9000-0000";
            this.maskedTextBoxContato.Name = "maskedTextBoxContato";
            this.maskedTextBoxContato.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxContato.TabIndex = 54;
            this.maskedTextBoxContato.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDados.Location = new System.Drawing.Point(425, 123);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(253, 225);
            this.dataGridViewDados.TabIndex = 68;
            this.dataGridViewDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewDados_CellMouseDoubleClick);
            // 
            // buttonExcluirFuncionario
            // 
            this.buttonExcluirFuncionario.Location = new System.Drawing.Point(467, 94);
            this.buttonExcluirFuncionario.Name = "buttonExcluirFuncionario";
            this.buttonExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirFuncionario.TabIndex = 71;
            this.buttonExcluirFuncionario.Text = "Excluir";
            this.buttonExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // buttonEditarFuncionario
            // 
            this.buttonEditarFuncionario.Location = new System.Drawing.Point(562, 94);
            this.buttonEditarFuncionario.Name = "buttonEditarFuncionario";
            this.buttonEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarFuncionario.TabIndex = 72;
            this.buttonEditarFuncionario.Text = "Editar";
            this.buttonEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 430);
            this.Controls.Add(this.buttonEditarFuncionario);
            this.Controls.Add(this.buttonExcluirFuncionario);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.maskedTextBoxContato);
            this.Controls.Add(this.maskedTextBoxId);
            this.Controls.Add(this.maskedTextBoxMatricula);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.salvar_VoltarFuncionario);
            this.Controls.Add(this.labelFuncionarioEmail);
            this.Controls.Add(this.textBoxFuncionarioEmail);
            this.Controls.Add(this.labelFuncionarioReSenha);
            this.Controls.Add(this.labelFuncionarioSenha);
            this.Controls.Add(this.labelFuncionarioContato);
            this.Controls.Add(this.labelFuncionarioNomeCompleto);
            this.Controls.Add(this.labelFuncionarioMatricula);
            this.Controls.Add(this.labelFuncionarioCPF);
            this.Controls.Add(this.labelFuncionarioID);
            this.Controls.Add(this.radioButtonFuncionarioBalcao);
            this.Controls.Add(this.radioButtonFuncionarioAdm);
            this.Controls.Add(this.textBoxFuncionarioRe);
            this.Controls.Add(this.textBoxFuncionarioSenha);
            this.Controls.Add(this.textBoxFuncionarioNome);
            this.Controls.Add(this.labelFuncionarioCadastro);
            this.KeyPreview = true;
            this.Name = "Cadastro_Funcionario";
            this.Text = "Cadastro_Funcionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Funcionario_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastro_Funcionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFuncionarioCadastro;
        private TextBox textBoxFuncionarioNome;
        private TextBox textBoxFuncionarioSenha;
        private TextBox textBoxFuncionarioRe;
        private RadioButton radioButtonFuncionarioAdm;
        private RadioButton radioButtonFuncionarioBalcao;
        private Label labelFuncionarioID;
        private Label labelFuncionarioCPF;
        private Label labelFuncionarioMatricula;
        private Label labelFuncionarioNomeCompleto;
        private Label labelFuncionarioContato;
        private Label labelFuncionarioSenha;
        private Label labelFuncionarioReSenha;
        private Label labelFuncionarioEmail;
        private TextBox textBoxFuncionarioEmail;
        private Salvar_Voltar salvar_VoltarFuncionario;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxMatricula;
        private MaskedTextBox maskedTextBoxId;
        private MaskedTextBox maskedTextBoxContato;
        private DataGridView dataGridViewDados;
        private Button buttonExcluirFuncionario;
        private Button buttonEditarFuncionario;
    }
}