using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeAvaliativa1
{
    public partial class exercicio13 : Form
    {
        public exercicio13()
        {
            InitializeComponent();
        }

        private void addCafe_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double quantCafe = double.Parse(txtquatidadeCafe.Text);
            double quantArroz = double.Parse(txtquantidadeArroz.Text);
            double rCafe = quantCafe * 35;
            double rArroz = quantArroz * 8.29;
            double Resultado = rCafe + rArroz;
            lblResultado.Text = "Total da sua compra e R$" + Resultado + "";
        }
    }
}
