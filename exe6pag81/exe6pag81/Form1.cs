using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe6pag81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] mat = new int[4, 6];
            int[] soma = new int[6];

            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = i + j;
                }
            }

            
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    soma[j] += mat[i, j];
                }
            }

            int media = 0;
            for (int i = 0; i < soma.Length; i++)
            {
                media += soma[i];
            }
            lblResultado.Text = "Soma das colunas: ";
             for (int i = 0; i < soma.Length; i++)
            {
                lblResultado.Text += "\nColuna " + (i + 1) + ": " + soma[i];
            }
            lblResultado.Text += "\nMédia das colunas: " + (media / soma.Length);
        }
    }
}
