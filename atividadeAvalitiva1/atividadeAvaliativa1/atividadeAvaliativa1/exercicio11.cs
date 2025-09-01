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
    public partial class exercicio11 : Form
    {
        public exercicio11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblK_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Celsius = double.Parse(txtCelsius.Text);
            double F = (9 / 5) * Celsius + 32;
            double K = Celsius + 273;
            lblF.Text = "A TEMPERATURA EM FARENHEIT E: " + F + "";
            lblK.Text = "A TEMPERATURA EM KELVIN E: "+ K + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
