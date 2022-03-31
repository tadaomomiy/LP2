using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            double x;
            if (!Double.TryParse(txtLadoA.Text, out x))
            {
                MessageBox.Show("colocar numero valido");

            }
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            double x;
            if (!Double.TryParse(txtLadoB.Text, out x))
            {
                MessageBox.Show("colocar numero valido");

            }
        }

        private void txtLadoC_Validated(object sender, EventArgs e)
        {
            double x;
            if (!Double.TryParse(txtLadoC.Text, out x))
                MessageBox.Show("colocar numero valido");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if (!Double.TryParse(txtLadoC.Text, out ladoC))
                MessageBox.Show("colocar numero valido");

            if (!Double.TryParse(txtLadoB.Text, out ladoB))
            {
                MessageBox.Show("colocar numero valido");
                txtLadoB.Focus();
            }

            if (!Double.TryParse(txtLadoA.Text, out ladoA))
            {
                MessageBox.Show("colocar numero valido");
                txtLadoA.Focus();
            }

            else
            if (Math.Abs(ladoB - ladoC) < ladoA && ladoA < ladoB + ladoC &&
                Math.Abs(ladoA - ladoC) < ladoB && ladoB < ladoA + ladoC &&
                Math.Abs(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                    txtResultado.Text = "TRIÂNGULO EQUILÁTERO";
                else
                if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                    txtResultado.Text = "TRIÂNGULO ESCALENO";

                else
                    txtResultado.Text = "TRIÂNGULO ISÓSCELES";
            }

            else
                txtResultado.Text = "NÂO É TRIÂNGULO";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
