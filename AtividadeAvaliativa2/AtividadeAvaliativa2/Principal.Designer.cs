namespace AtividadeAvaliativa2
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio1ToolStripMenuItem,
            this.exercicio1ToolStripMenuItem1,
            this.exercicio1ToolStripMenuItem2,
            this.exercicio1ToolStripMenuItem3});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // exercicio1ToolStripMenuItem
            // 
            this.exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            this.exercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio1ToolStripMenuItem.Text = "Exercicio1";
            this.exercicio1ToolStripMenuItem.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
            // 
            // exercicio1ToolStripMenuItem1
            // 
            this.exercicio1ToolStripMenuItem1.Name = "exercicio1ToolStripMenuItem1";
            this.exercicio1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exercicio1ToolStripMenuItem1.Text = "Exercicio2";
            this.exercicio1ToolStripMenuItem1.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem1_Click);
            // 
            // exercicio1ToolStripMenuItem2
            // 
            this.exercicio1ToolStripMenuItem2.Name = "exercicio1ToolStripMenuItem2";
            this.exercicio1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.exercicio1ToolStripMenuItem2.Text = "Exercicio3";
            this.exercicio1ToolStripMenuItem2.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem2_Click);
            // 
            // exercicio1ToolStripMenuItem3
            // 
            this.exercicio1ToolStripMenuItem3.Name = "exercicio1ToolStripMenuItem3";
            this.exercicio1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.exercicio1ToolStripMenuItem3.Text = "Exercicio4";
            this.exercicio1ToolStripMenuItem3.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = " 2 Etapa - Aluno: Ian Fidelis Dos Reis Silva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

