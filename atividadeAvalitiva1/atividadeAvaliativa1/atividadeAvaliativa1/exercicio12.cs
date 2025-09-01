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
    public partial class exercicio12 : Form
    {
        public exercicio12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Acertos = double.Parse(txtAcertos.Text);
            double Erros = 10 - Acertos;
            double porcentagemErros = (Erros / 10) * 100;
            double porcentagemAcertos = (Acertos / 10) * 100;
            lblErros.Text = "O NUMERO DE ERROS E: " + Erros + "";
            lblporcentagemAcertos.Text = "A PORCENTAGEM DE ACERTOS E: %" + porcentagemAcertos + "";
            lblporcentagemErros.Text = "A PORCENTAGEM DE ERROS E: %" + porcentagemErros + "";
        }
    }
}
