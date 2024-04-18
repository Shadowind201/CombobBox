using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombobBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Janeiro";
                    break;
                case 2:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Fevereiro";
                    break;
                case 3:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Março";
                    break;
                case 4:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Abril";
                    break;
                case 5:
                    lblMensaagem.Text = "Olà " + textBoxNome.Text + " você nasceu em Maio";
                    break;
                case 6:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Junho";
                    break;
                case 7:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Julho";
                    break;
                case 8:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Agosto";
                    break;
                case 9:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Setembro";
                    break;
                case 10:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Outubro";
                    break;
                case 11:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Novembro";
                    break;
                case 12:
                    lblMensaagem.Text = "Olá " + textBoxNome.Text + " você nasceu em Dezembro";
                    break;

                default:
                    lblMensaagem.Text = " Por favor escolha uma opção de números ; MÊS Não encontrado";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
