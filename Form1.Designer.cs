namespace BubleSort
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blubleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blubleSortToolStripMenuItem,
            this.selectSortToolStripMenuItem,
            this.pilhaToolStripMenuItem,
            this.filaToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // blubleSortToolStripMenuItem
            // 
            this.blubleSortToolStripMenuItem.Name = "blubleSortToolStripMenuItem";
            this.blubleSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blubleSortToolStripMenuItem.Text = "BlubleSort";
            this.blubleSortToolStripMenuItem.Click += new System.EventHandler(this.blubleSortToolStripMenuItem_Click);
            // 
            // selectSortToolStripMenuItem
            // 
            this.selectSortToolStripMenuItem.Name = "selectSortToolStripMenuItem";
            this.selectSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectSortToolStripMenuItem.Text = "SelectSort";
            this.selectSortToolStripMenuItem.Click += new System.EventHandler(this.selectSortToolStripMenuItem_Click);
            // 
            // pilhaToolStripMenuItem
            // 
            this.pilhaToolStripMenuItem.Name = "pilhaToolStripMenuItem";
            this.pilhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilhaToolStripMenuItem.Text = "Pilha";
            this.pilhaToolStripMenuItem.Click += new System.EventHandler(this.pilhaToolStripMenuItem_Click);
            // 
            // filaToolStripMenuItem
            // 
            this.filaToolStripMenuItem.Name = "filaToolStripMenuItem";
            this.filaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filaToolStripMenuItem.Text = "Fila";
            this.filaToolStripMenuItem.Click += new System.EventHandler(this.filaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blubleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaToolStripMenuItem;
    }
}

