using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxQtdeFilhos.SelectedIndex = 0;
        }

        private void mskbxNomeFunc_Validated(object sender, EventArgs e)
        {
            if (mskbxNomeFunc.Text == "")
            {
                MessageBox.Show("Digite seu nome(LETRAS)");
            }
        }

        private void mskbxSalBruto_Validated(object sender, EventArgs e)
        {
            Double salarioBruto;
            if (!double.TryParse(mskbxSalBruto.Text, out salarioBruto))
            {
                MessageBox.Show("salario invalido");
            }
        }

        private void btnVerifDesconto_Click(object sender, EventArgs e)
        {
            Double salarioBruto, qtdeFilhos = 0, descontoINSS = 0, descontoIRPF = 0, salFamilia = 0, salLiquido;

            if (mskbxNomeFunc.Text == "")
            {
                MessageBox.Show("Digite seu nome(LETRAS)");
                return;
            }

            if (cbxQtdeFilhos.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a quantidade de filhos");
                return;
            }

            if (!double.TryParse(mskbxSalBruto.Text, out salarioBruto) || (!double.TryParse(cbxQtdeFilhos.SelectedItem.ToString(), out qtdeFilhos)))
            {
                MessageBox.Show("salario invalido");
                return;
            }

            else
            {
                if (salarioBruto <= 800.47)
                {
                    mskbxAliquoINSS.Text = "7.65%";
                    descontoINSS = (7.65 / 100) * salarioBruto;
                    mskbxDescINSS.Text = descontoINSS.ToString("N2");
                }

                else if (salarioBruto <= 1050)
                {
                    mskbxAliquoINSS.Text = "8.65%";
                    descontoINSS = (8.65 / 100) * salarioBruto;
                    mskbxDescINSS.Text = descontoINSS.ToString("N2");
                }

                else if (salarioBruto <= 1400.77)
                {
                    mskbxAliquoINSS.Text = "9.00%";
                    descontoINSS = (9.00 / 100) * salarioBruto;
                    mskbxDescINSS.Text = descontoINSS.ToString("N2");
                }

                else if (salarioBruto <= 2801.56)
                {
                    mskbxAliquoINSS.Text = "11.00%";
                    descontoINSS = (11.00 / 100) * salarioBruto;
                    mskbxDescINSS.Text = descontoINSS.ToString("N2");
                }
                else
                {
                    mskbxAliquoINSS.Text = "teto";
                    descontoINSS = 308.17;
                    mskbxDescINSS.Text = descontoINSS.ToString("N2");
                }
            }

            {
                if (salarioBruto <= 1257.12)
                {
                    mskbxAliquoIRPF.Text = "Isento";
                    mskbxDescIRPF.Text = "Isento";
                }

                else if (salarioBruto <= 2512.08)
                {
                    mskbxAliquoIRPF.Text = "15.00%";
                    descontoIRPF = (15.00 / 100) * salarioBruto;
                    mskbxDescIRPF.Text = descontoIRPF.ToString("N2");
                }

                else
                {
                    mskbxAliquoIRPF.Text = "27.5%";
                    descontoIRPF = (27.5 / 100) * salarioBruto;
                    mskbxDescIRPF.Text = descontoIRPF.ToString("N2");

                }
            }


            {
                if (salarioBruto <= 435.52)
                {
                    salFamilia = (qtdeFilhos * 22.33);
                    mskbxSalFamilia.Text = salFamilia.ToString("N2");
                }
                else if (salarioBruto <= 654.61)
                {
                    salFamilia = (qtdeFilhos * 15.74);
                    mskbxSalFamilia.Text = salFamilia.ToString("N2");
                }
                else
                {
                    mskbxSalFamilia.Text = "0";
                }

            }

            salLiquido = salarioBruto - descontoINSS - descontoIRPF + salFamilia;
            mskbxSalLiquid.Text = salLiquido.ToString("N2");


            lblDados.MaximumSize = new Size(500, 0);
            lblDados.AutoSize = true;

            string estCivil = "", sexo = "";
            {
                if (rbtnMasc.Checked)
                {
                    sexo = " do Sr. ";
                }
                else
                {
                    sexo = " da Sra. ";
                }

                if (ckbxCasado.Checked)
                {
                    estCivil = " Casado(a) ";
                }
                else
                {
                    estCivil = " Solteiro(a) ";
                }

                lblDados.Text = "Está descrito abaixo os descontos e o salario" + sexo + mskbxNomeFunc.Text + " que é" + estCivil + "e que tem " + qtdeFilhos + " filhos(s).";
            }
        }

    }
}
