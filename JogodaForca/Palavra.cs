using System;
using System.Windows.Forms;

namespace JogodaForca
{
    public partial class frmPalavra : Form
    {
        public frmPalavra()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text == "")
            {
                MessageBox.Show("Campo não preenchido!", "Atenção", MessageBoxButtons.OK,
                                                                                MessageBoxIcon.Error);
            }
            else/*Rogério Almeida Pereira*/
            {
                string pa = txtPalavra.Text, caracter = "";
                int a=0;
                for(int i=0; i < pa.Length;i++)
                {                                   //tratamento de erro
                    if (pa[i].ToString() == "!"
                        || pa[i].ToString() == "@"
                        || pa[i].ToString() == "#"
                        || pa[i].ToString() == "$"
                        || pa[i].ToString() == "%"
                        || pa[i].ToString() == "¨"
                        || pa[i].ToString() == "&"
                        || pa[i].ToString() == "*"
                        || pa[i].ToString() == "("
                        || pa[i].ToString() == ")"
                        || pa[i].ToString() == "-"
                        || pa[i].ToString() == "_"
                        || pa[i].ToString() == "+"
                        || pa[i].ToString() == "="
                        || pa[i].ToString() == "§"
                        || pa[i].ToString() == "´"
                        || pa[i].ToString() == "`"
                        || pa[i].ToString() == "{"
                        || pa[i].ToString() == "["
                        || pa[i].ToString() == "ª"
                        || pa[i].ToString() == "^"
                        || pa[i].ToString() == "~"
                        || pa[i].ToString() == "}"
                        || pa[i].ToString() == "]"
                        || pa[i].ToString() == "º"
                        || pa[i].ToString() == ","
                        || pa[i].ToString() == "<"
                        || pa[i].ToString() == "."
                        || pa[i].ToString() == ">"
                        || pa[i].ToString() == ";"
                        || pa[i].ToString() == ":"
                        || pa[i].ToString() == "/"
                        || pa[i].ToString() == "\\"
                        || pa[i].ToString() == "|"
                        || pa[i].ToString() == "?"
                        || pa[i].ToString() == "°"
                        || pa[i].ToString() == "¬"
                        || pa[i].ToString() == "¢"
                        || pa[i].ToString() == "£"
                        || pa[i].ToString() == "³"
                        || pa[i].ToString() == "²"
                        || pa[i].ToString() == "¹"
                        || pa[i].ToString() == "0"
                        || pa[i].ToString() == "1"
                        || pa[i].ToString() == "2"
                        || pa[i].ToString() == "3"
                        || pa[i].ToString() == "4"
                        || pa[i].ToString() == "5"
                        || pa[i].ToString() == "6"
                        || pa[i].ToString() == "7"
                        || pa[i].ToString() == "8"
                        || pa[i].ToString() == "9")
                    {
                        a++;
                        caracter += pa[i];
                    }
                }
                int cont = 0;
                for (int i = 0; i < pa.Length; i++) { cont++; }

                if(cont > 0 && cont <=2)
                {
                    MessageBox.Show("A palavra tem que ter no mínimo 3 caracteres!", "Erro!",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(a > 0)
                {
                    MessageBox.Show("Os seguintes caracteres não são válidos: " + caracter, "Erro!",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    new frmJogodaforca().Palavra(txtPalavra.Text);
                    txtPalavra.Text = null;
                    new frmJogodaforca().ShowDialog();//esses dois têm que ficar porque quando fechar a
                                                         //janela principal esse também será fechado
                }/*Rogério Almeida Pereira*/
            }
        }
    }
}
