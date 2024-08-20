namespace BubleSort
{
    partial class frmPilha
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
            this.lbxPilha = new System.Windows.Forms.ListBox();
            this.btnEmpilhar = new System.Windows.Forms.Button();
            this.btnDesempilhar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numEmpilhar = new System.Windows.Forms.NumericUpDown();
            this.numDesempilhar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpilhar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesempilhar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxPilha
            // 
            this.lbxPilha.FormattingEnabled = true;
            this.lbxPilha.Location = new System.Drawing.Point(87, 195);
            this.lbxPilha.Name = "lbxPilha";
            this.lbxPilha.Size = new System.Drawing.Size(205, 225);
            this.lbxPilha.TabIndex = 2;
            // 
            // btnEmpilhar
            // 
            this.btnEmpilhar.Location = new System.Drawing.Point(365, 50);
            this.btnEmpilhar.Name = "btnEmpilhar";
            this.btnEmpilhar.Size = new System.Drawing.Size(100, 23);
            this.btnEmpilhar.TabIndex = 3;
            this.btnEmpilhar.Text = "Empilhar";
            this.btnEmpilhar.UseVisualStyleBackColor = true;
            this.btnEmpilhar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDesempilhar
            // 
            this.btnDesempilhar.Location = new System.Drawing.Point(365, 116);
            this.btnDesempilhar.Name = "btnDesempilhar";
            this.btnDesempilhar.Size = new System.Drawing.Size(100, 23);
            this.btnDesempilhar.TabIndex = 4;
            this.btnDesempilhar.Text = "Desempilhar";
            this.btnDesempilhar.UseVisualStyleBackColor = true;
            this.btnDesempilhar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empilhar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desempilhar";
            // 
            // numEmpilhar
            // 
            this.numEmpilhar.Location = new System.Drawing.Point(93, 53);
            this.numEmpilhar.Name = "numEmpilhar";
            this.numEmpilhar.Size = new System.Drawing.Size(205, 20);
            this.numEmpilhar.TabIndex = 7;
            // 
            // numDesempilhar
            // 
            this.numDesempilhar.Location = new System.Drawing.Point(87, 119);
            this.numDesempilhar.Name = "numDesempilhar";
            this.numDesempilhar.Size = new System.Drawing.Size(205, 20);
            this.numDesempilhar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(90, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(84, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "*valor desempilhado";
            // 
            // frmPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDesempilhar);
            this.Controls.Add(this.numEmpilhar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesempilhar);
            this.Controls.Add(this.btnEmpilhar);
            this.Controls.Add(this.lbxPilha);
            this.Name = "frmPilha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPilha";
            ((System.ComponentModel.ISupportInitialize)(this.numEmpilhar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesempilhar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxPilha;
        private System.Windows.Forms.Button btnEmpilhar;
        private System.Windows.Forms.Button btnDesempilhar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numEmpilhar;
        private System.Windows.Forms.NumericUpDown numDesempilhar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}