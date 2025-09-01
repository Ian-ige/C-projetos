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
    public partial class Exercicio3: Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btnMudaCorDeFundo_Click(object sender, EventArgs e)
        {
            if (rbdCorAzul.Checked == true)
            {
                BackColor = Color.Blue;
            }

            else if (rbdCorAmarelo.Checked == true)
            {
                BackColor = Color.Yellow;
            }
            else if(rbdCorVermelho.Checked == true)
            {
                BackColor = Color.Red;
            }
        }
    }
}
