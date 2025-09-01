using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace exe4pag81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[30, 30];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            
            int menorValor = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < menorValor)
                    {
                        menorValor = matrix[i, j];
                    }
                }
            }

            
            int soma = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                soma += matrix[i, i];
            }

            
            string elementos = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i * j == 30)
                    {
                        elementos += " " + matrix[i, j];
                    }
                }
            }
            
            string resultado = "";
            resultado += "Elementos que o produto dos indices sao igual a ordem da matriz: " + elementos + "\n";
            resultado += "Menor valor da matriz: " + menorValor + "\n";
            resultado += "Media da diagonal principal: " + (+soma / 30) + "\n";
            resultado += "Elementos onde i * j == 30:" + "\n";

            lblResultado.Text = resultado;





        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
