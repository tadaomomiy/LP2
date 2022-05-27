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
    public partial class frmExercicio4 : Form
    {
        string nome;
        int producao = 0,b=0,c=0,d=0;
        double salario = 0,gratificacao=0;
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            int x=0;
            foreach (char letra in txtNome.Text)
            {
                 if (!char.IsLetter(txtNome.Text, x))
                    x++;
            }
            if (x == 0)
            {
                nome = txtNome.Text;
            }
            else
            {
                MessageBox.Show("Contém números ou caracteres especiais no nome!");
                txtNome.Clear();
                txtNome.Focus();
            }
        }

        private void txtMatricula_Validated(object sender, EventArgs e)
        {
            int matricula=0;
            if (!int.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("Favor digitar números");
                txtMatricula.Clear();
                txtMatricula.Focus();
            }
            else if (matricula < 0)
            {
                MessageBox.Show("O valor da mátricula não pode ser menor que zero!");
                txtMatricula.Clear();
                txtMatricula.Focus();
            }
        }

        private void txtProducao_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProducao.Text, out producao))
            {
                MessageBox.Show("Digite a quantidade de produção!");
                txtProducao.Clear();
                txtProducao.Focus();
            }
            else if (producao < 0)
            {
                MessageBox.Show("A quantidade produzida não pode ser menor que zero!");
                txtProducao.Clear();
                txtProducao.Focus();
            }
        }

        private void txtSalario_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Digite o valor do salário!");
                txtSalario.Clear();
                txtSalario.Focus();
            }
            else if (salario < 0)
            {
                MessageBox.Show("O salário digitado não pode ser menor que zero!");
                txtSalario.Clear();
                txtSalario.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salBruto = 0;

            if ((txtMatricula.Text != "") && (txtProducao.Text != "")
                && (txtSalario.Text != "") && (txtGratificacao.Text != "") && (txtNome.Text != ""))
            {
                b = (producao >= 100) ? 1 : 0;
                c = (producao >= 120) ? 1 : 0;
                d = (producao >= 150) ? 1 : 0;

                salBruto = salario + gratificacao + salario * (0.05 * b + 0.1 * c + 0.1 * d);

                if (salBruto <= 7000)
                {
                    txtSalBruto.Text = salBruto.ToString("N2");
                }
                else if (salBruto > 7000 && producao >= 150 && gratificacao > 0)
                {
                    txtSalBruto.Text = salBruto.ToString("N2");
                }
                else
                {
                    txtSalBruto.Text = "7.000,00";
                }
            }
            else
                MessageBox.Show("Preencha todos os campos!");
        }

        private void txtGratificacao_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGratificacao.Text, out gratificacao))
            {
                MessageBox.Show("Digite apenas números na gratificação!");
                txtGratificacao.Clear();
                txtGratificacao.Focus();
            }
            else if (gratificacao < 0)
            {
                MessageBox.Show("A gratificação não pode ser menor negativa!");
                txtGratificacao.Clear();
                txtGratificacao.Focus();
            }
        }
    }
}
