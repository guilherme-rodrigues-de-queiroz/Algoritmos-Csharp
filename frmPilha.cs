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
    public partial class frmPilha : Form
    {
        const int tm = 5;
        decimal[] pilha = new decimal[tm];
        int topo = -1;
        public frmPilha()
        {
            InitializeComponent();
        }

        //metodo para mostrar a pilha
        private void MostrarPilha()
        {
            lbxPilha.Items.Clear();

            for(int i = tm-1; i >= 0; i--)
            {
                lbxPilha.Items.Add(pilha[i]);
            }
        }

        //Metodo Push / Empilhar
        private void Push(decimal pValor)
        {
            if(topo == tm - 1)
            {
                MessageBox.Show("Pilha cheia!");
                return;
            }

            topo++;
            pilha[topo] = pValor;

            MostrarPilha();
        }

        //Metodo Put
        private decimal Put()
        {
            decimal vazio = 0;
            decimal retorno = -1;

            if(topo < 0)
            {
                MessageBox.Show("Pilha vazia!");
                return vazio;
            }

            if(topo >= 0)
            {
                retorno = pilha[topo];
                pilha[topo] = 0;
                topo--;
            }

            return retorno;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Push(numEmpilhar.Value);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            numDesempilhar.Value = Put();
            MostrarPilha();
        }
    }
}
