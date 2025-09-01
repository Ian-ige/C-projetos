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
    public partial class exercicio14 : Form
    {
        public exercicio14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double quant = double.Parse(txtQuantidade.Text);
            double valor = double.Parse(txtValor.Text);
            double r = valor * quant;
            if (r >= 200)
            {
                double desconto = (15 * r) / 100;
                double Resultado = r - desconto ;

                lblResultado.Text = "O VALOR TOTAL COM 15% DE DESCONTO É R$" + Resultado + "\n o desconto foi de: R$"+ desconto;
            }
            else{
                double Resultado = r;
                lblResultado.Text = "O VALOR TOTAL É R$" + Resultado + " ";

            }
                
                

        }
    }
}
