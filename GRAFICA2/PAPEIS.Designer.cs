
namespace GRAFICA2
{
    partial class PAPEIS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CADCLIENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.CADPAPEL = new System.Windows.Forms.ToolStripMenuItem();
            this.ATUPAPEL = new System.Windows.Forms.ToolStripMenuItem();
            this.ATUCLIENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.ATUALIZARPAPEL = new System.Windows.Forms.ToolStripMenuItem();
            this.EXCPAPEL = new System.Windows.Forms.ToolStripMenuItem();
            this.EXCCLIENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.EXCLUIRPAPEL = new System.Windows.Forms.ToolStripMenuItem();
            this.SAIRPAPEL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.ATUPAPEL,
            this.EXCPAPEL,
            this.SAIRPAPEL});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CADCLIENTE,
            this.CADPAPEL});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRAR";
            // 
            // CADCLIENTE
            // 
            this.CADCLIENTE.Name = "CADCLIENTE";
            this.CADCLIENTE.Size = new System.Drawing.Size(180, 22);
            this.CADCLIENTE.Text = "CLIENTE";
            // 
            // CADPAPEL
            // 
            this.CADPAPEL.Name = "CADPAPEL";
            this.CADPAPEL.Size = new System.Drawing.Size(180, 22);
            this.CADPAPEL.Text = "PAPEL";
            // 
            // ATUPAPEL
            // 
            this.ATUPAPEL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ATUCLIENTE,
            this.ATUALIZARPAPEL});
            this.ATUPAPEL.Name = "ATUPAPEL";
            this.ATUPAPEL.Size = new System.Drawing.Size(79, 20);
            this.ATUPAPEL.Text = "ATUALIZAR";
            // 
            // ATUCLIENTE
            // 
            this.ATUCLIENTE.Name = "ATUCLIENTE";
            this.ATUCLIENTE.Size = new System.Drawing.Size(180, 22);
            this.ATUCLIENTE.Text = "CLIENTE";
            // 
            // ATUALIZARPAPEL
            // 
            this.ATUALIZARPAPEL.Name = "ATUALIZARPAPEL";
            this.ATUALIZARPAPEL.Size = new System.Drawing.Size(180, 22);
            this.ATUALIZARPAPEL.Text = "PAPEL";
            // 
            // EXCPAPEL
            // 
            this.EXCPAPEL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EXCCLIENTE,
            this.EXCLUIRPAPEL});
            this.EXCPAPEL.Name = "EXCPAPEL";
            this.EXCPAPEL.Size = new System.Drawing.Size(64, 20);
            this.EXCPAPEL.Text = "EXCLUIR";
            // 
            // EXCCLIENTE
            // 
            this.EXCCLIENTE.Name = "EXCCLIENTE";
            this.EXCCLIENTE.Size = new System.Drawing.Size(180, 22);
            this.EXCCLIENTE.Text = "CLIENTE";
            // 
            // EXCLUIRPAPEL
            // 
            this.EXCLUIRPAPEL.Name = "EXCLUIRPAPEL";
            this.EXCLUIRPAPEL.Size = new System.Drawing.Size(180, 22);
            this.EXCLUIRPAPEL.Text = "PAPEL";
            // 
            // SAIRPAPEL
            // 
            this.SAIRPAPEL.Name = "SAIRPAPEL";
            this.SAIRPAPEL.Size = new System.Drawing.Size(43, 20);
            this.SAIRPAPEL.Text = "SAIR";
            this.SAIRPAPEL.Click += new System.EventHandler(this.SAIR1_Click);
            // 
            // PAPEIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1904, 1039);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PAPEIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAPEIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CADCLIENTE;
        private System.Windows.Forms.ToolStripMenuItem CADPAPEL;
        private System.Windows.Forms.ToolStripMenuItem ATUPAPEL;
        private System.Windows.Forms.ToolStripMenuItem ATUCLIENTE;
        private System.Windows.Forms.ToolStripMenuItem ATUALIZARPAPEL;
        private System.Windows.Forms.ToolStripMenuItem EXCPAPEL;
        private System.Windows.Forms.ToolStripMenuItem EXCCLIENTE;
        private System.Windows.Forms.ToolStripMenuItem EXCLUIRPAPEL;
        private System.Windows.Forms.ToolStripMenuItem SAIRPAPEL;
    }
}