using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa2
{
    public partial class Exercicio1: Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int Inicio = int.Parse(cmbInicio.Text);
            int Fim = int.Parse(cmbFim.Text);


            while (Inicio <= Fim)
            {
                lstNumeros.Items.Add(Inicio);
                Inicio++;
            }

        }
    }
}
