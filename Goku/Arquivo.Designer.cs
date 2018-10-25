namespace Goku
{
    partial class Arquivo
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelArquivo = new System.Windows.Forms.Label();
            this.Abrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelArquivo
            // 
            this.labelArquivo.AutoSize = true;
            this.labelArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArquivo.Location = new System.Drawing.Point(13, 9);
            this.labelArquivo.Name = "labelArquivo";
            this.labelArquivo.Size = new System.Drawing.Size(117, 20);
            this.labelArquivo.TabIndex = 0;
            this.labelArquivo.Text = "Abra o arquivo";
            // 
            // Abrir
            // 
            this.Abrir.Location = new System.Drawing.Point(29, 32);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(75, 23);
            this.Abrir.TabIndex = 1;
            this.Abrir.Text = "Abrir Arquivo";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 69);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.labelArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Arquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArquivo;
        private System.Windows.Forms.Button Abrir;
    }
}

