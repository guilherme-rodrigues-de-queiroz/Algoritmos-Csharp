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
    public partial class frmFila : Form
    {
        const int tm = 5;
        string[] fila = new string[tm];
        int p = 0;
        int u = -1;
        int qtd = 0;
        public frmFila()
        {
            InitializeComponent();
        }

        //Metodo adicionar
        private void Adicionar(string pNome)
        {
            if (qtd == tm)
            {
                MessageBox.Show("Fila cheia");
                return;
            }
            u++;
            fila[u] = pNome;
            qtd++;

        }

        //Metodo retirar
        private string Retirar()
        {
            string retorno = "";

            if (qtd == 0)
            {
                MessageBox.Show("Fila vazia");
                return "";
            }

            retorno = fila[p];
            fila[p] = "";
            p++;
            qtd--;
            return retorno;
        }

        //Metodo mostrar fila
        private void MostrarFila()
        {
            lbxFila.Items.Clear();

            for (int i = 0; i < tm; i++)
            {
                if (fila[i] != null)
                    lbxFila.Items.Add(fila[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            MostrarFila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Retirar();
            MostrarFila();
        }
    }
}
