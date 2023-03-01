
namespace GRAFICA2
{
    partial class PADRAO
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
            this.CBBOPCOES = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CBBOPCOES
            // 
            this.CBBOPCOES.FormattingEnabled = true;
            this.CBBOPCOES.Items.AddRange(new object[] {
            "CADASTRAR",
            "ATUALIZAR",
            "EXCLUIR"});
            this.CBBOPCOES.Location = new System.Drawing.Point(356, 63);
            this.CBBOPCOES.Name = "CBBOPCOES";
            this.CBBOPCOES.Size = new System.Drawing.Size(169, 21);
            this.CBBOPCOES.TabIndex = 0;
            // 
            // PADRAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1784, 861);
            this.Controls.Add(this.CBBOPCOES);
            this.Name = "PADRAO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBBOPCOES;
    }
}

