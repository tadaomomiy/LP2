using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade9
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string auxiliarQtde,auxiliarPco;
            double soma = 0;
            int[] quantidade = new int[10];
            double[] preco = new double[10];
            double[] total = new double[10];
            int i = 0;

            lstbxQtde.Items.Clear();
            lstbxPreco.Items.Clear();
            lstbxTotal.Items.Clear();

            for (int x = 0; x < 10; x++)
            {
                auxiliarQtde = Interaction.InputBox("Digite a quantidade para o produto : " + (x + 1), "Estoque de cada produto");
                if (auxiliarQtde == "")
                    break;
                else if (!int.TryParse(auxiliarQtde, out quantidade[x]))
                {
                    MessageBox.Show("Valor inválido, Favor digitar número Inteiro!");
                    x -= 1;
                }
                else if (quantidade[x] < 0)
                {
                    MessageBox.Show("O estoque não pode ser menor que zero!");
                    x -= 1;
                }
                else
                {
                    lstbxProduto.Items.Add("Produto " + (x + 1));
                    lstbxQtde.Items.Add("--> " + quantidade[x]);
                    while (i == x)
                    {
                        auxiliarPco = Interaction.InputBox("Digite o preço para o produto : " + (i + 1), "Preço unitário do produto");
                        if (auxiliarPco == "")
                            break;
                        else if (!double.TryParse(auxiliarPco, out preco[i]))
                        {
                            MessageBox.Show("Valor inválido, Favor digitar um valor válido!");
                            i -= 1;
                        }
                        else if (preco[i] <= 0)
                        {
                            MessageBox.Show("O preço não pode ser negativo!");
                            x -= 1;
                        }
                        else
                        {
                            total[i] = preco[i] * quantidade[i];
                            soma += total[i];
                            lstbxPreco.Items.Add(preco[i]);
                        }
                        i++;
                    }       
                }
                lstbxTotal.Items.Add(total[x]);
            }
            txtFaturamento.Text = "R$ " + soma.ToString("N2");
        }
    }
}
