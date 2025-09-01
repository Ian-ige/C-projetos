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
    public partial class exercicio10 : Form
    {
        public exercicio10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Raio = double.Parse(txtRaio.Text);
            double Resultado = (4 / 3) * Math.PI * Math.Pow(Raio,3);
            lblResultado.Text = Resultado.ToString();
        }
    }
}
