namespace Analisador_Lexico
{
    partial class Form1
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbLexemas = new System.Windows.Forms.ListBox();
            this.lbReservadas = new System.Windows.Forms.ListBox();
            this.lbErros = new System.Windows.Forms.ListBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(30, 24);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(30, 66);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(236, 148);
            this.tbInput.TabIndex = 1;
            // 
            // lbLexemas
            // 
            this.lbLexemas.FormattingEnabled = true;
            this.lbLexemas.Location = new System.Drawing.Point(298, 9);
            this.lbLexemas.Name = "lbLexemas";
            this.lbLexemas.Size = new System.Drawing.Size(170, 446);
            this.lbLexemas.TabIndex = 2;
            // 
            // lbReservadas
            // 
            this.lbReservadas.FormattingEnabled = true;
            this.lbReservadas.Location = new System.Drawing.Point(504, 9);
            this.lbReservadas.Name = "lbReservadas";
            this.lbReservadas.Size = new System.Drawing.Size(170, 446);
            this.lbReservadas.TabIndex = 3;
            // 
            // lbErros
            // 
            this.lbErros.FormattingEnabled = true;
            this.lbErros.Location = new System.Drawing.Point(712, 9);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(170, 446);
            this.lbErros.TabIndex = 4;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(30, 220);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(236, 23);
            this.btnAnalisar.TabIndex = 5;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 492);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.lbReservadas);
            this.Controls.Add(this.lbLexemas);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnCarregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ListBox lbLexemas;
        private System.Windows.Forms.ListBox lbReservadas;
        private System.Windows.Forms.ListBox lbErros;
        private System.Windows.Forms.Button btnAnalisar;
    }
}

