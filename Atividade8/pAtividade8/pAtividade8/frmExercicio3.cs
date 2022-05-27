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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string auxiliar = txtFrase.Text.Replace(" ", "");
            char[] arrayAuxiliar = auxiliar.ToCharArray();
            string reversed = "";
            Array.Reverse(arrayAuxiliar);

            if (txtFrase.Text == "")
            {
                MessageBox.Show("O campo 'frase' está vazio!\nDigite uma frase.");
                txtFrase.Focus();
            }
            else
            {
                foreach (char c in arrayAuxiliar)
                {
                    reversed = reversed + c.ToString();
                }

                if (reversed == auxiliar)
                {
                    MessageBox.Show("Esta palavra é um Palindromo");
                }
                else
                {
                    MessageBox.Show("Esta palavra não é um Palindromo");
                }
            }
        }
    }
}
