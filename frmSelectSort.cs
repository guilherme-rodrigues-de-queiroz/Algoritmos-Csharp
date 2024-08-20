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
    public partial class frmSelectSort : Form
    {
        int[] dados = new int[5];
        public frmSelectSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados[0] = 5;
            dados[1] = 1;
            dados[2] = 4;
            dados[3] = 2;
            dados[4] = 3;
            int aux;

            listBox1.Items.Clear();
            for(int y = 0; y < dados.Length; y++)
            {
                listBox1.Items.Add(dados[y]);
            }

            for(int i = dados.Length -1; i >0; i--)
            {
                for(int x = 0; x < i; x++)
                {
                    if (dados[x] > dados[x + 1])
                    {
                        aux = dados[x];
                        dados[x] = dados[x + 1];
                        dados[x+1] = aux;
                    }
                }
            }

            listBox2.Items.Clear();
            for(int x = 0; x < dados.Length; x++)
            {
                listBox2.Items.Add(dados[x]);
            }
        }
    }
}
