namespace Pastelaria_do_Zé
{
    partial class Comandas
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
            this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
            this.dataGridViewComandaItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewPodutos = new System.Windows.Forms.DataGridView();
            this.labelComandaCadastrar = new System.Windows.Forms.Label();
            this.labelComandasAbertas = new System.Windows.Forms.Label();
            this.labelItensComandas = new System.Windows.Forms.Label();
            this.labelAddProduto = new System.Windows.Forms.Label();
            this.buttonAbrirComanda = new System.Windows.Forms.Button();
            this.labelComandaNumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxBuscaProduto = new System.Windows.Forms.TextBox();
            this.labelComandaBuscarProd = new System.Windows.Forms.Label();
            this.buttonComandaBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComandas
            // 
            this.dataGridViewComandas.AllowUserToAddRows = false;
            this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandas.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewComandas.MultiSelect = false;
            this.dataGridViewComandas.Name = "dataGridViewComandas";
            this.dataGridViewComandas.RowTemplate.Height = 25;
            this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandas.Size = new System.Drawing.Size(382, 150);
            this.dataGridViewComandas.TabIndex = 0;
            this.dataGridViewComandas.SelectionChanged += new System.EventHandler(this.dataGridViewComandas_SelectionChanged);
            // 
            // dataGridViewComandaItens
            // 
            this.dataGridViewComandaItens.AllowUserToAddRows = false;
            this.dataGridViewComandaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandaItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaItens.Location = new System.Drawing.Point(12, 313);
            this.dataGridViewComandaItens.MultiSelect = false;
            this.dataGridViewComandaItens.Name = "dataGridViewComandaItens";
            this.dataGridViewComandaItens.RowTemplate.Height = 25;
            this.dataGridViewComandaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaItens.Size = new System.Drawing.Size(382, 150);
            this.dataGridViewComandaItens.TabIndex = 1;
            this.dataGridViewComandaItens.DoubleClick += new System.EventHandler(this.dataGridViewComandaItens_DoubleClick);
            // 
            // dataGridViewPodutos
            // 
            this.dataGridViewPodutos.AllowUserToAddRows = false;
            this.dataGridViewPodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPodutos.Location = new System.Drawing.Point(412, 138);
            this.dataGridViewPodutos.MultiSelect = false;
            this.dataGridViewPodutos.Name = "dataGridViewPodutos";
            this.dataGridViewPodutos.RowTemplate.Height = 25;
            this.dataGridViewPodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPodutos.Size = new System.Drawing.Size(390, 325);
            this.dataGridViewPodutos.TabIndex = 2;
            this.dataGridViewPodutos.DoubleClick += new System.EventHandler(this.dataGridViewPodutos_DoubleClick);
            // 
            // labelComandaCadastrar
            // 
            this.labelComandaCadastrar.AutoSize = true;
            this.labelComandaCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelComandaCadastrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComandaCadastrar.ForeColor = System.Drawing.Color.Black;
            this.labelComandaCadastrar.Location = new System.Drawing.Point(12, 9);
            this.labelComandaCadastrar.Name = "labelComandaCadastrar";
            this.labelComandaCadastrar.Size = new System.Drawing.Size(184, 28);
            this.labelComandaCadastrar.TabIndex = 39;
            this.labelComandaCadastrar.Text = "Cadastrar Comanda";
            // 
            // labelComandasAbertas
            // 
            this.labelComandasAbertas.AutoSize = true;
            this.labelComandasAbertas.Location = new System.Drawing.Point(12, 120);
            this.labelComandasAbertas.Name = "labelComandasAbertas";
            this.labelComandasAbertas.Size = new System.Drawing.Size(107, 15);
            this.labelComandasAbertas.TabIndex = 40;
            this.labelComandasAbertas.Text = "Comandas Abertas";
            // 
            // labelItensComandas
            // 
            this.labelItensComandas.AutoSize = true;
            this.labelItensComandas.Location = new System.Drawing.Point(12, 295);
            this.labelItensComandas.Name = "labelItensComandas";
            this.labelItensComandas.Size = new System.Drawing.Size(224, 15);
            this.labelItensComandas.TabIndex = 41;
            this.labelItensComandas.Text = "Itens Comanda (Duplo clique para editar)";
            // 
            // labelAddProduto
            // 
            this.labelAddProduto.AutoSize = true;
            this.labelAddProduto.Location = new System.Drawing.Point(412, 67);
            this.labelAddProduto.Name = "labelAddProduto";
            this.labelAddProduto.Size = new System.Drawing.Size(377, 15);
            this.labelAddProduto.TabIndex = 42;
            this.labelAddProduto.Text = "Adicionar Produto Comanda (Duplo clique para adicionar a comanda)";
            // 
            // buttonAbrirComanda
            // 
            this.buttonAbrirComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAbrirComanda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAbrirComanda.Location = new System.Drawing.Point(148, 67);
            this.buttonAbrirComanda.Name = "buttonAbrirComanda";
            this.buttonAbrirComanda.Size = new System.Drawing.Size(116, 38);
            this.buttonAbrirComanda.TabIndex = 43;
            this.buttonAbrirComanda.Text = "Abrir Comanda";
            this.buttonAbrirComanda.UseVisualStyleBackColor = false;
            this.buttonAbrirComanda.Click += new System.EventHandler(this.ButtonAbrirComanda_Click);
            // 
            // labelComandaNumero
            // 
            this.labelComandaNumero.AutoSize = true;
            this.labelComandaNumero.Location = new System.Drawing.Point(12, 58);
            this.labelComandaNumero.Name = "labelComandaNumero";
            this.labelComandaNumero.Size = new System.Drawing.Size(54, 15);
            this.labelComandaNumero.TabIndex = 44;
            this.labelComandaNumero.Text = "Número:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 45;
            // 
            // textBoxBuscaProduto
            // 
            this.textBoxBuscaProduto.Location = new System.Drawing.Point(426, 109);
            this.textBoxBuscaProduto.Name = "textBoxBuscaProduto";
            this.textBoxBuscaProduto.Size = new System.Drawing.Size(150, 23);
            this.textBoxBuscaProduto.TabIndex = 46;
            // 
            // labelComandaBuscarProd
            // 
            this.labelComandaBuscarProd.AutoSize = true;
            this.labelComandaBuscarProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelComandaBuscarProd.Location = new System.Drawing.Point(426, 91);
            this.labelComandaBuscarProd.Name = "labelComandaBuscarProd";
            this.labelComandaBuscarProd.Size = new System.Drawing.Size(91, 15);
            this.labelComandaBuscarProd.TabIndex = 47;
            this.labelComandaBuscarProd.Text = "Buscar Produto:";
            // 
            // buttonComandaBuscar
            // 
            this.buttonComandaBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonComandaBuscar.Location = new System.Drawing.Point(593, 97);
            this.buttonComandaBuscar.Name = "buttonComandaBuscar";
            this.buttonComandaBuscar.Size = new System.Drawing.Size(75, 35);
            this.buttonComandaBuscar.TabIndex = 48;
            this.buttonComandaBuscar.Text = "Buscar";
            this.buttonComandaBuscar.UseVisualStyleBackColor = false;
            this.buttonComandaBuscar.Click += new System.EventHandler(this.ButtonComandaBuscar_Click);
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 475);
            this.Controls.Add(this.buttonComandaBuscar);
            this.Controls.Add(this.labelComandaBuscarProd);
            this.Controls.Add(this.textBoxBuscaProduto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelComandaNumero);
            this.Controls.Add(this.buttonAbrirComanda);
            this.Controls.Add(this.labelAddProduto);
            this.Controls.Add(this.labelItensComandas);
            this.Controls.Add(this.labelComandasAbertas);
            this.Controls.Add(this.labelComandaCadastrar);
            this.Controls.Add(this.dataGridViewPodutos);
            this.Controls.Add(this.dataGridViewComandaItens);
            this.Controls.Add(this.dataGridViewComandas);
            this.Name = "Comandas";
            this.Text = "Comandas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewComandas;
        private DataGridView dataGridViewComandaItens;
        private DataGridView dataGridViewPodutos;
        private Label labelComandaCadastrar;
        private Label labelComandasAbertas;
        private Label labelItensComandas;
        private Label labelAddProduto;
        private Button buttonAbrirComanda;
        private Label labelComandaNumero;
        private TextBox textBox1;
        private TextBox textBoxBuscaProduto;
        private Label labelComandaBuscarProd;
        private Button buttonComandaBuscar;
    }
}