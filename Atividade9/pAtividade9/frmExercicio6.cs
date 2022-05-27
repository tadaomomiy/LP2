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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string auxiliarNomes = "";
            int[] qtdeCaracteres = new int[2];
            string[] nomes = new string[2];
            string[] removeEspaco = new string[2];

            lstbxNomes.Items.Clear();

            for (int i = 0; i < 2; i++)
            {
                auxiliarNomes = Interaction.InputBox("Digite o " + (i + 1) + "º nome: ", "Listagem de nomes");
                if (auxiliarNomes == "")
                {
                    break;
                }else if (!char.IsLetter(auxiliarNomes, i))
                {
                    MessageBox.Show("Favor digitar um nome válido!");
                    i -= 1;
                }else
                {
                    foreach (char c in auxiliarNomes)
                    {
                        nomes[i] += c.ToString();
                    }

                    removeEspaco[i] = nomes[i].Replace(" ", "");
                    qtdeCaracteres[i] = removeEspaco[i].Length;

                    lstbxNomes.Items.Add("O nome: " + nomes[i] + " tem " + qtdeCaracteres[i].ToString() + " caracteres.");
                }
            }

            
        }
    }
}
