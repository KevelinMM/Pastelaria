namespace Pastelaria_do_Zé
{
    partial class Lista
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
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.buttonFunCadastrados = new System.Windows.Forms.Button();
            this.buttonCliCadastrados = new System.Windows.Forms.Button();
            this.buttonProCadastrados = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelFuncionarioCadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.Size = new System.Drawing.Size(516, 250);
            this.dataGridViewDados.TabIndex = 56;
            // 
            // buttonFunCadastrados
            // 
            this.buttonFunCadastrados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFunCadastrados.Location = new System.Drawing.Point(66, 69);
            this.buttonFunCadastrados.Name = "buttonFunCadastrados";
            this.buttonFunCadastrados.Size = new System.Drawing.Size(126, 22);
            this.buttonFunCadastrados.TabIndex = 57;
            this.buttonFunCadastrados.Text = "Funcionários ";
            this.buttonFunCadastrados.UseVisualStyleBackColor = false;
            this.buttonFunCadastrados.Click += new System.EventHandler(this.ButtonFunCadastrados_Click);
            // 
            // buttonCliCadastrados
            // 
            this.buttonCliCadastrados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCliCadastrados.Location = new System.Drawing.Point(207, 68);
            this.buttonCliCadastrados.Name = "buttonCliCadastrados";
            this.buttonCliCadastrados.Size = new System.Drawing.Size(126, 23);
            this.buttonCliCadastrados.TabIndex = 58;
            this.buttonCliCadastrados.Text = "Clientes";
            this.buttonCliCadastrados.UseVisualStyleBackColor = false;
            this.buttonCliCadastrados.Click += new System.EventHandler(this.buttonCliCadastrados_Click);
            // 
            // buttonProCadastrados
            // 
            this.buttonProCadastrados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonProCadastrados.Location = new System.Drawing.Point(348, 68);
            this.buttonProCadastrados.Name = "buttonProCadastrados";
            this.buttonProCadastrados.Size = new System.Drawing.Size(126, 23);
            this.buttonProCadastrados.TabIndex = 59;
            this.buttonProCadastrados.Text = "Produtos";
            this.buttonProCadastrados.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSair.Location = new System.Drawing.Point(453, 363);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 60;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelFuncionarioCadastro
            // 
            this.labelFuncionarioCadastro.AutoSize = true;
            this.labelFuncionarioCadastro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFuncionarioCadastro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelFuncionarioCadastro.Location = new System.Drawing.Point(176, 20);
            this.labelFuncionarioCadastro.Name = "labelFuncionarioCadastro";
            this.labelFuncionarioCadastro.Size = new System.Drawing.Size(200, 28);
            this.labelFuncionarioCadastro.TabIndex = 61;
            this.labelFuncionarioCadastro.Text = "Usuários Cadastrados";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 398);
            this.Controls.Add(this.labelFuncionarioCadastro);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonProCadastrados);
            this.Controls.Add(this.buttonCliCadastrados);
            this.Controls.Add(this.buttonFunCadastrados);
            this.Controls.Add(this.dataGridViewDados);
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDados;
        private Button buttonFunCadastrados;
        private Button buttonCliCadastrados;
        private Button buttonProCadastrados;
        private Button buttonSair;
        private Label labelFuncionarioCadastro;
    }
}