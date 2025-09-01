using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] matrix = new string[9, 9];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = " * ";
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i == 4 || i == 5)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (i > 2 & j == 1 & i < 7)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (i > 1 & j == 2 & i < 8)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (i > 0 & j == 3 & i < 9)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (j == 4)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (j == 5)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (i > 0 & j == 6 & i < 9)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (i > 1 & j == 7 & i < 8)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else if (i > 2 & j == 8 & i < 7)
                    {
                        lblResultado.Text += matrix[i, j];
                    }
                    else
                    {
                        lblResultado.Text += " ";
                    }
                }
                lblResultado.Text += "\n";
            }
        }
    }
}
