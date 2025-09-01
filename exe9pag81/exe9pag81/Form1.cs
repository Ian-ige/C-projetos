using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe9pag81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[3, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }
            lblResultado.Text += "matriz: \n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   lblResultado.Text += matrix[i, j] + " ";
                }
                lblResultado.Text += "\n";
            }

            

            int[,] transposta = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposta[j, i] = matrix[i, j];
                }
                
            }
            lblResultado.Text += "transposta: \n";
            for (int i = 0; i < transposta.GetLength(0); i++)
            {
                for (int j = 0; j < transposta.GetLength(1); j++)
                {
                    lblResultado.Text += transposta[i, j] + " ";
                }
                lblResultado.Text += "\n";
            }
            
        }
    }
}
