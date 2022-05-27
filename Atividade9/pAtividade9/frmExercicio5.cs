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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string auxiliarNotas="";
            double soma = 0;
            double[,] media = new double[20, 3];
            double[] lista = new double[20];

            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    auxiliarNotas = Interaction.InputBox("Digite a nota nº" + (x + 1) + " do aluno nº" + (i + 1), "Lançamento de notas");
                    if (auxiliarNotas == "")
                        break;
                    if (!double.TryParse(auxiliarNotas, out media[i, x]))
                    {
                        MessageBox.Show("Valor Inválido, Favor digitar uma nota válida!");
                        x -= 1;     
                    }
                    else if (media[i, x] < 0 || media[i, x] > 10)
                    {
                        MessageBox.Show("A nota precisa estar entre 0 e 10!");
                        x -= 1;
                    }  
                    else
                        soma += media[i, x];
                }
                lista[i] = soma/3;

                if (auxiliarNotas == "")
                {
                    break;
                }

                soma = 0;

                lstbxLista.Items.Add("\nAluno " + (i + 1) + ":  média: " + lista[i].ToString("N1"));
            }
        }
    }
}
