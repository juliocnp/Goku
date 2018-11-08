namespace Goku
{
    partial class Resultados
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
            this.textBoxTestes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.radioButtonForcaBruta = new System.Windows.Forms.RadioButton();
            this.radioButtonGuloso = new System.Windows.Forms.RadioButton();
            this.radioButtonDinamico = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTestes
            // 
            this.textBoxTestes.Location = new System.Drawing.Point(12, 32);
            this.textBoxTestes.Multiline = true;
            this.textBoxTestes.Name = "textBoxTestes";
            this.textBoxTestes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTestes.Size = new System.Drawing.Size(218, 406);
            this.textBoxTestes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultados:";
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.Location = new System.Drawing.Point(399, 32);
            this.textBoxResultados.Multiline = true;
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultados.Size = new System.Drawing.Size(90, 406);
            this.textBoxResultados.TabIndex = 3;
            // 
            // radioButtonForcaBruta
            // 
            this.radioButtonForcaBruta.AutoSize = true;
            this.radioButtonForcaBruta.Location = new System.Drawing.Point(275, 142);
            this.radioButtonForcaBruta.Name = "radioButtonForcaBruta";
            this.radioButtonForcaBruta.Size = new System.Drawing.Size(80, 17);
            this.radioButtonForcaBruta.TabIndex = 4;
            this.radioButtonForcaBruta.TabStop = true;
            this.radioButtonForcaBruta.Text = "Força Bruta";
            this.radioButtonForcaBruta.UseVisualStyleBackColor = true;
            // 
            // radioButtonGuloso
            // 
            this.radioButtonGuloso.AutoSize = true;
            this.radioButtonGuloso.Location = new System.Drawing.Point(275, 186);
            this.radioButtonGuloso.Name = "radioButtonGuloso";
            this.radioButtonGuloso.Size = new System.Drawing.Size(58, 17);
            this.radioButtonGuloso.TabIndex = 5;
            this.radioButtonGuloso.TabStop = true;
            this.radioButtonGuloso.Text = "Guloso";
            this.radioButtonGuloso.UseVisualStyleBackColor = true;
            // 
            // radioButtonDinamico
            // 
            this.radioButtonDinamico.AutoSize = true;
            this.radioButtonDinamico.Location = new System.Drawing.Point(275, 226);
            this.radioButtonDinamico.Name = "radioButtonDinamico";
            this.radioButtonDinamico.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDinamico.TabIndex = 6;
            this.radioButtonDinamico.TabStop = true;
            this.radioButtonDinamico.Text = "Dinâmico";
            this.radioButtonDinamico.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Processar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonDinamico);
            this.Controls.Add(this.radioButtonGuloso);
            this.Controls.Add(this.radioButtonForcaBruta);
            this.Controls.Add(this.textBoxResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTestes);
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resultados_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTestes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.RadioButton radioButtonForcaBruta;
        private System.Windows.Forms.RadioButton radioButtonGuloso;
        private System.Windows.Forms.RadioButton radioButtonDinamico;
        private System.Windows.Forms.Button button1;
    }
}