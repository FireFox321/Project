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
            this.lbLexemas = new System.Windows.Forms.ListBox();
            this.lbReservadas = new System.Windows.Forms.ListBox();
            this.lbErros = new System.Windows.Forms.ListBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(30, 9);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
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
            this.btnAnalisar.Location = new System.Drawing.Point(30, 457);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(236, 23);
            this.btnAnalisar.TabIndex = 5;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(30, 50);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(236, 401);
            this.rtbInput.TabIndex = 6;
            this.rtbInput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 501);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.lbReservadas);
            this.Controls.Add(this.lbLexemas);
            this.Controls.Add(this.btnCarregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox lbLexemas;
        private System.Windows.Forms.ListBox lbReservadas;
        private System.Windows.Forms.ListBox lbErros;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.RichTextBox rtbInput;
    }
}

