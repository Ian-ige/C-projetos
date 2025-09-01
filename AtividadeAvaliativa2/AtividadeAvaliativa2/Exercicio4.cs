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
    public partial class Exercicio4: Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (chkArroz.Checked == true) {

                total = total + 26;

            }
            if (chkFeijao.Checked == true)
            {
                total = total + 8.6;
            }
            if (chkOleo.Checked == true)
            {
                total = total + 7.3;
            }
            if (chkAcucar.Checked == true)
            {
                total = total + 19.20;
            }
            if (chkMacarrao.Checked == true)
            {
                total = total + 6.7;
            }
            if (chkMaionese.Checked == true)
            {
                total = total + 4.6;
            }
            if (chkLeite.Checked == true)
            {
                total = total + 4.89;
            }
            if (chkManteiga.Checked == true)
            {
                total = total + 18.2;
            }
            if (chkOvos.Checked == true)
            {
                total = total + 7.3;
            }
            if (chkSal.Checked == true)
            {
                total = total + 4.10;
            }
            lblResultado.Text = ""+total+"";
        }
    }
}
