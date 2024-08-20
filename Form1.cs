using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void blubleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buble frmBuble = new Buble();
            frmBuble.ShowDialog();
        }

        private void selectSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectSort frmSelect = new frmSelectSort();
            frmSelect.ShowDialog();
        }

        private void pilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilha Pilha = new frmPilha();
            Pilha.ShowDialog();
        }

        private void filaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFila Fila = new frmFila();
            Fila.ShowDialog();
        }
    }
}
