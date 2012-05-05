using System;
using System.Windows.Forms;

namespace JogodaForca
{
    public partial class frmJogodaforca : Form
    {
        public frmJogodaforca()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A palavra era " + palav, "Desistiu!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        public static string palav;
        public void Palavra(string p)
        {
            palav = p;
        }

        public void PartesCorpo()
        {
            if(pbxCabeca.Visible == false) //cabeça
            {
                pbxCabeca.Visible = true;
            }
            else if(pbxCorpo.Visible == false) //corpo
            {
                pbxCorpo.Visible = true;
            }
            else if(pbxBracoEsquerdo.Visible == false) //braço esquerdo
            {
                pbxBracoEsquerdo.Visible = true;
            }
            else if(pbxBracoDireito.Visible == false) //braço Direito
            {
                pbxBracoDireito.Visible = true;
            }
            else if(pbxPernaEsquerda.Visible == false) //perna esquerda
            {
                pbxPernaEsquerda.Visible = true;
            }
            else if(pbxPernaDireita.Visible == false) //perna direita
            {
                pbxPernaDireita.Visible = true;
                MessageBox.Show("Ihuuuuuu deu VELHA!!!!!", "Não ganhou!");
                MessageBox.Show("A palavra era " + palav, "Ninguém Ganhou!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void btnTentar_Click(object sender, EventArgs e)
        {
            int quanti = 0;
            for (int i = 0; i < txtPalavra.Text.Length; i++)
            {
                quanti++;
            }

            if (quanti == 0)
            {
                MessageBox.Show("- Digite uma letra para verificar se tem ela na palavra\n- Ou digite uma palavra para saber se adivinhou!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (quanti == 1)
                {
                    int contador = 0;
                    string letra = txtPalavra.Text, agora = lblPalavra.Text;
                    txtPalavra.Text = null;
                    lblPalavra.Text = null;

                    for (int i = 0; i < palav.Length; i++)
                    {
                        //MessageBox.Show(letra.ToString() + "\n\n" + palav[i].ToString());
                        if (letra == palav[i].ToString())
                        {
                            lblPalavra.Text += palav[i];
                            contador++;
                        }
                        else
                        {
                            lblPalavra.Text += agora[i];
                        }
                    }
                    if (contador == 0)
                    {
                        MessageBox.Show("Não tem a letra!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //colocar as partes dos corpo
                        PartesCorpo();
                        txtLetrastentadas.Text += " - " + letra;
                        txtPalavra.Text = null;
                    }
                }
                else
                {
                    if (txtPalavra.Text == palav)
                    {
                        MessageBox.Show("Acertou! A palavra é " + palav, "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Não é esta a palavra!", "Palavra errada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbxPalavrastentadas.Items.Add(txtPalavra.Text);
                        txtPalavra.Text = null;
                    }
                }
            }
            if (lblPalavra.Text == palav)
            {
                MessageBox.Show("Acertou! A palavra é " + palav, "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }


        private void frmJogodaforca_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < palav.Length; i++)
            {
                lblPalavra.Text += "-";
            }

            lblLetras.Text = palav.Length.ToString() + " " + lblLetras.Text;
        }
    }
}
