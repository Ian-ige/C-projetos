using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Idade = double.Parse(txtIdade.Text);
            double Anos = 2025 - Idade;
            double Dias = 365 * Anos;
            double Semanas = Dias / 7;
            double Meses = Dias / 30;
            lblResultado.Text = "Voce tem aproximadamente:\n" + Anos + "Anos\n" + Meses + "Meses\n" + Dias + "Dias\n" + Semanas + "Semanas";

        }
    }
}
