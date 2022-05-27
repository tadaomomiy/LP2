using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio2 : Form
    {
        double numN;
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numH=1,x=2;
            int i;

            if (txtNumN.Text == "")
            {
                MessageBox.Show("Digite um número.\n O campo N está vazio!");
                txtNumN.Focus();
            }
            else if (!double.TryParse(txtNumN.Text, out numN))
            {
                MessageBox.Show("Favor digitar um número válido!");
                txtNumN.Text = null;
            }
            else if (numN <= 0)
            {
                MessageBox.Show("O número digitado é menor ou igual a zero!");
                txtNumN.Text = null;
            }
            else 
            { 
                for (i = 0; i < numN; i++)
                {
                    numH += (1 / x);
                    x++;
                    if (x > numN)
                        break;
                }
                txtNumH.Text = numH.ToString("N2");
            }

                
        }
    }
}
