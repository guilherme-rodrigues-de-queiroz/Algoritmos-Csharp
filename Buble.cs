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
    public partial class Buble : Form
    {
        int[] dados = new int[10];
        public Buble()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados[0] = 10;
            dados[1] = 1;
            dados[2] = 9;
            dados[3] = 2;
            dados[4] = 8;
            dados[5] = 3;
            dados[6] = 7;
            dados[7] = 4;
            dados[8] = 6;
            dados[9] = 5;
            int aux;

            for (int i = dados.Length - 1; i > 0; i--){
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

            listBox1.Items.Clear();
            for(int x = 0; x < dados.Length; x++)
            {
                listBox1.Items.Add(dados[x]);
            }
        }
    }
}
