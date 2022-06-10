namespace Pastelaria_do_Zé
{
    partial class Cadastrar_Produto
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelProdutoDescricao = new System.Windows.Forms.Label();
            this.labelProdutoNome = new System.Windows.Forms.Label();
            this.labelProdutoID = new System.Windows.Forms.Label();
            this.textBoxProdutoNome = new System.Windows.Forms.TextBox();
            this.labelProdutoCadastrar = new System.Windows.Forms.Label();
            this.labelPodutoPreco = new System.Windows.Forms.Label();
            this.labelProdutoImagem = new System.Windows.Forms.Label();
            this.textBoxProdutoDescricao = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.salvar_VoltarProduto = new Pastelaria_do_Zé.Salvar_Voltar();
            this.maskedTextBoxProduto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonExcluirProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 463);
            this.splitter1.TabIndex = 52;
            this.splitter1.TabStop = false;
            // 
            // labelProdutoDescricao
            // 
            this.labelProdutoDescricao.AutoSize = true;
            this.labelProdutoDescricao.Location = new System.Drawing.Point(45, 186);
            this.labelProdutoDescricao.Name = "labelProdutoDescricao";
            this.labelProdutoDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelProdutoDescricao.TabIndex = 47;
            this.labelProdutoDescricao.Text = "Descrição:";
            // 
            // labelProdutoNome
            // 
            this.labelProdutoNome.AutoSize = true;
            this.labelProdutoNome.Location = new System.Drawing.Point(45, 135);
            this.labelProdutoNome.Name = "labelProdutoNome";
            this.labelProdutoNome.Size = new System.Drawing.Size(43, 15);
            this.labelProdutoNome.TabIndex = 46;
            this.labelProdutoNome.Text = "Nome:";
            // 
            // labelProdutoID
            // 
            this.labelProdutoID.AutoSize = true;
            this.labelProdutoID.Location = new System.Drawing.Point(45, 79);
            this.labelProdutoID.Name = "labelProdutoID";
            this.labelProdutoID.Size = new System.Drawing.Size(21, 15);
            this.labelProdutoID.TabIndex = 45;
            this.labelProdutoID.Text = "ID:";
            // 
            // textBoxProdutoNome
            // 
            this.textBoxProdutoNome.Location = new System.Drawing.Point(45, 153);
            this.textBoxProdutoNome.Name = "textBoxProdutoNome";
            this.textBoxProdutoNome.Size = new System.Drawing.Size(252, 23);
            this.textBoxProdutoNome.TabIndex = 2;
            // 
            // labelProdutoCadastrar
            // 
            this.labelProdutoCadastrar.AutoSize = true;
            this.labelProdutoCadastrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProdutoCadastrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelProdutoCadastrar.Location = new System.Drawing.Point(246, 22);
            this.labelProdutoCadastrar.Name = "labelProdutoCadastrar";
            this.labelProdutoCadastrar.Size = new System.Drawing.Size(172, 28);
            this.labelProdutoCadastrar.TabIndex = 38;
            this.labelProdutoCadastrar.Text = "Cadastrar Produto";
            // 
            // labelPodutoPreco
            // 
            this.labelPodutoPreco.AutoSize = true;
            this.labelPodutoPreco.Location = new System.Drawing.Point(190, 79);
            this.labelPodutoPreco.Name = "labelPodutoPreco";
            this.labelPodutoPreco.Size = new System.Drawing.Size(40, 15);
            this.labelPodutoPreco.TabIndex = 55;
            this.labelPodutoPreco.Text = "Preço:";
            // 
            // labelProdutoImagem
            // 
            this.labelProdutoImagem.AutoSize = true;
            this.labelProdutoImagem.Location = new System.Drawing.Point(45, 248);
            this.labelProdutoImagem.Name = "labelProdutoImagem";
            this.labelProdutoImagem.Size = new System.Drawing.Size(54, 15);
            this.labelProdutoImagem.TabIndex = 57;
            this.labelProdutoImagem.Text = "Imagem:";
            // 
            // textBoxProdutoDescricao
            // 
            this.textBoxProdutoDescricao.Location = new System.Drawing.Point(45, 212);
            this.textBoxProdutoDescricao.Multiline = true;
            this.textBoxProdutoDescricao.Name = "textBoxProdutoDescricao";
            this.textBoxProdutoDescricao.Size = new System.Drawing.Size(252, 24);
            this.textBoxProdutoDescricao.TabIndex = 4;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.Image = global::Pastelaria_do_Zé.Properties.Resources.image_icon_jpg;
            this.pictureBoxProduto.Location = new System.Drawing.Point(45, 267);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(144, 110);
            this.pictureBoxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProduto.TabIndex = 61;
            this.pictureBoxProduto.TabStop = false;
            this.pictureBoxProduto.Click += new System.EventHandler(this.PictureBoxProduto_Click);
            // 
            // salvar_VoltarProduto
            // 
            this.salvar_VoltarProduto.Location = new System.Drawing.Point(33, 399);
            this.salvar_VoltarProduto.Name = "salvar_VoltarProduto";
            this.salvar_VoltarProduto.Size = new System.Drawing.Size(583, 64);
            this.salvar_VoltarProduto.TabIndex = 5;
            // 
            // maskedTextBoxProduto
            // 
            this.maskedTextBoxProduto.Location = new System.Drawing.Point(190, 97);
            this.maskedTextBoxProduto.Mask = "$99999,99";
            this.maskedTextBoxProduto.Name = "maskedTextBoxProduto";
            this.maskedTextBoxProduto.Size = new System.Drawing.Size(107, 23);
            this.maskedTextBoxProduto.TabIndex = 62;
            this.maskedTextBoxProduto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(45, 97);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(107, 23);
            this.maskedTextBox1.TabIndex = 63;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(138, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(283, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(283, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "*";
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialog1";
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDados.Location = new System.Drawing.Point(359, 114);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(257, 263);
            this.dataGridViewDados.TabIndex = 67;
            this.dataGridViewDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDados_CellContentDoubleClick);
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.Location = new System.Drawing.Point(493, 85);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarProduto.TabIndex = 68;
            this.buttonEditarProduto.Text = "Editar";
            this.buttonEditarProduto.UseVisualStyleBackColor = true;
            this.buttonEditarProduto.Click += new System.EventHandler(this.ButtonEditarProduto_Click);
            // 
            // buttonExcluirProduto
            // 
            this.buttonExcluirProduto.Location = new System.Drawing.Point(400, 85);
            this.buttonExcluirProduto.Name = "buttonExcluirProduto";
            this.buttonExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirProduto.TabIndex = 69;
            this.buttonExcluirProduto.Text = "Excluir";
            this.buttonExcluirProduto.UseVisualStyleBackColor = true;
            this.buttonExcluirProduto.Click += new System.EventHandler(this.ButtonExcluirProduto_Click);
            // 
            // Cadastrar_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 463);
            this.Controls.Add(this.buttonExcluirProduto);
            this.Controls.Add(this.buttonEditarProduto);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBoxProduto);
            this.Controls.Add(this.salvar_VoltarProduto);
            this.Controls.Add(this.pictureBoxProduto);
            this.Controls.Add(this.textBoxProdutoDescricao);
            this.Controls.Add(this.labelProdutoImagem);
            this.Controls.Add(this.labelPodutoPreco);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelProdutoDescricao);
            this.Controls.Add(this.labelProdutoNome);
            this.Controls.Add(this.labelProdutoID);
            this.Controls.Add(this.textBoxProdutoNome);
            this.Controls.Add(this.labelProdutoCadastrar);
            this.KeyPreview = true;
            this.Name = "Cadastrar_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar_Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastrar_Produto_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastrar_Produto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Splitter splitter1;
        private Label labelProdutoDescricao;
        private Label labelProdutoNome;
        private Label labelProdutoID;
        private TextBox textBoxProdutoNome;
        private Label labelProdutoCadastrar;
        private Label labelPodutoPreco;
        private Label labelProdutoImagem;
        private TextBox textBoxProdutoDescricao;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox pictureBoxProduto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Salvar_Voltar salvar_VoltarProduto;
        private MaskedTextBox maskedTextBoxProduto;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialogImagem;
        private DataGridView dataGridViewDados;
        private Button buttonExcluirProduto;
        private Button buttonEditarProduto;
    }
}