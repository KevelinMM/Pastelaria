namespace Pastelaria_do_Zé
{
    /// <summary>
    /// 
    /// </summary>
    partial class Salvar_Voltar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Voltar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Voltar.Location = new System.Drawing.Point(10, 14);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(85, 36);
            this.Voltar.TabIndex = 1;
            this.Voltar.Text = "VOLTAR";
            this.Voltar.UseVisualStyleBackColor = false;
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Salvar.Location = new System.Drawing.Point(493, 14);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(85, 36);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = false;
            // 
            // Salvar_Voltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Salvar);
            this.Name = "Salvar_Voltar";
            this.Size = new System.Drawing.Size(592, 64);
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        public Button Voltar;
        /// <summary>
        /// 
        /// </summary>
        public Button Salvar;
    }
}
