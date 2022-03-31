using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskbxAltura_Validated(object sender, EventArgs e)
        {
            double altura;
            if (!double.TryParse(mskbxAltura.Text, out altura))
                MessageBox.Show("número inválido");
        }

        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            double peso;
            if (!double.TryParse(mskbxPeso.Text, out peso))
                MessageBox.Show("número inválido");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double altura;
            Double peso;
            if (!Double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("número inválido");
                mskbxAltura.Focus();
            }
            else
               if (!Double.TryParse(mskbxPeso.Text, out peso))
            {
                MessageBox.Show("número inválido");
                mskbxPeso.Focus();
            }
            else
                if (altura <= 0)
            {
                MessageBox.Show("Altura não pode ser menor ou igual a Zero");
                mskbxAltura.Focus();
            }
            else
                if (peso <= 0)
            {
                MessageBox.Show("Peso não pode ser menor ou igual a Zero");
                mskbxPeso.Focus();
            }
            else
            {
                // Calculo
                Double dobroAltura = altura * altura;

                Double IMC = peso / dobroAltura;

                if (IMC < 18.5) //Magreza
                {
                    MessageBox.Show("Seu IMC é :" + IMC.ToString("N2") + " É Menor que 18,5 e é classificado como Magreza e com Obesidade Grau 0");
                }
                else 
                    if (IMC >= 18.5 && IMC < 25)
                {
                    MessageBox.Show("Seu IMC é :" + IMC.ToString("N2") + " Está entre 18,5 e 24,9 e é classificado como Normal e com Obesidade Grau 0");
                }
                else
                    if (IMC >= 25 && IMC < 30)
                {
                    MessageBox.Show("Seu IMC é :" + IMC.ToString("N2") + " Está entre 25,0 e 29,9 e é classificado como Sobrepeso e com Obesidade Grau I");
                }
                else
                    if (IMC >= 30 && IMC < 40)
                {
                    MessageBox.Show("Seu IMC é :" + IMC.ToString("N2") + " Está entre 30,0 e 39,9 e é classificado como Obesidade e com Obesidade Grau II");
                }
                else
                    if (IMC >= 40)
                {
                    MessageBox.Show("Seu IMC é :" + IMC.ToString("N2") + " É maior que 40 e é classificado como Obesidade  Grave e com Obesidade Grau III");
                }
            }
        }
    }
}
