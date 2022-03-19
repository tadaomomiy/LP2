using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            double valor1;
            if (!double.TryParse(textBox1.Text, out valor1))
            MessageBox.Show("número inválido");
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            double valor2;
            if (!double.TryParse(textBox2.Text, out valor2))
                MessageBox.Show("número inválido");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double valor1;
            Double valor2;
            if (!Double.TryParse(textBox1.Text, out valor1))
            {
                MessageBox.Show("número inválido");
                textBox1.Focus();
            }
            else
               if (!Double.TryParse(textBox2.Text, out valor2))
            {
                MessageBox.Show("número inválido");
                textBox2.Focus();
            }
            else
            {
                // Calculo
                Double soma = valor1 + valor2;

                textBox3.Text = soma.ToString("N2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double valor1;
            Double valor2;
            if (!Double.TryParse(textBox1.Text, out valor1))
            {
                MessageBox.Show("número inválido");
                textBox1.Focus();
            }
            else
               if (!Double.TryParse(textBox2.Text, out valor2))
            {
                MessageBox.Show("número inválido");
                textBox2.Focus();
            }
            else
            {
                // Calculo
                Double subtrair = valor1 - valor2;

                textBox3.Text = subtrair.ToString("N2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double valor1;
            Double valor2;
            if (!Double.TryParse(textBox1.Text, out valor1))
            {
                MessageBox.Show("número inválido");
                textBox1.Focus();
            }
            else
               if (!Double.TryParse(textBox2.Text, out valor2))
            {
                MessageBox.Show("número inválido");
                textBox2.Focus();
            }
            else
            {
                // Calculo
                Double multiplicar = valor1 * valor2;

                textBox3.Text = multiplicar.ToString("N2");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double valor1;
            Double valor2;
            if (!Double.TryParse(textBox1.Text, out valor1))
            {
                MessageBox.Show("número inválido");
                textBox1.Focus();
            }
            else
               if (!Double.TryParse(textBox2.Text, out valor2))
            {
                MessageBox.Show("número inválido");
                textBox2.Focus();
            }
            else 
                if (valor2 == 0)
            {
                MessageBox.Show("Divisão não pode ser 0");
                textBox2.Focus();
            }
            else
            {
                // Calculo
                Double multiplicar = valor1 / valor2;

                textBox3.Text = multiplicar.ToString("N2");
            }
        }
    }
}
