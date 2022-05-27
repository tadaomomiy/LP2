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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnContSpace_Click(object sender, EventArgs e)
        {
            string texto = rchtxtFrase.Text.Trim();
            int tamanho = texto.Length;
            int total = 0;
            int contador = 0;

            if (rchtxtFrase.Text == "")
            {
                MessageBox.Show("O campo 'frase' está vazio!\nDigite uma frase");
                rchtxtFrase.Focus();
            }
            else
            {

                while (contador < tamanho)
                {
                    if (texto[contador]==' ')
                    {
                        total += 1;
                    }
                    contador += 1;
                }
                MessageBox.Show("O número de espaços em branco no texto é: " + total.ToString());
            }
        }

        private void btnContR_Click(object sender, EventArgs e)
        {
            int letrasR = 0;

            if (rchtxtFrase.Text == "")
            {
                MessageBox.Show("O campo 'frase' está vazio!\nDigite uma frase");
                rchtxtFrase.Focus();
            }
            else
            {
                foreach (char c in rchtxtFrase.Text)
                {
                    if (char.ToUpper(c) == 'R')
                    {
                        letrasR++;
                    }
                }
                MessageBox.Show("O número de letras R é: " + letrasR.ToString());
            }
        }

        private void btnContOcorrencias_Click(object sender, EventArgs e)
        {
            int letrasResp = 0, i;
            string auxiliar = rchtxtFrase.Text.Replace(" ", "");

            if (rchtxtFrase.Text == "")
            {
                MessageBox.Show("O campo 'frase' está vazio!\nDigite uma frase");
                rchtxtFrase.Focus();
            }
            else
            {
                for (i = 1; i < auxiliar.Length; i++)
                {
                    if (auxiliar[i] == auxiliar[i - 1])
                    {
                        letrasResp += 1;
                    }
                }
                MessageBox.Show("Pares de letras repetidas: " + letrasResp.ToString());
            }
        }
    }
}
