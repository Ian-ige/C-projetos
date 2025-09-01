using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areaQuadrdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtAltura.Text);
            double l = double.Parse(txtLargura.Text);
            double Resultado = l * a;
            lblResultado.Text = Resultado.ToString();
        }
    }
}
