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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            int[] vetor = new int[20];

            for (var x = 0; x < 20; x++)
            {
                auxiliar = Interaction.InputBox("Digite um número para a posição = "+(x+1), "Entrada de dados");
                if (auxiliar == "")
                    break;
                else if (!int.TryParse(auxiliar, out vetor[x]))
                {
                    MessageBox.Show("Valor inválido, favor digitar um número inteiro");
                    x -= 1;
                }
            }

            Array.Reverse(vetor);
            auxiliar = "";

            foreach (int i in vetor)
            {
                auxiliar = auxiliar + "\n" + i;
            }
            MessageBox.Show(auxiliar);
        }
    }
}
