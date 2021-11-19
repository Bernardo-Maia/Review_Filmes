using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.BLL;

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Login : Form
    {
        loginBLL lgnBLL = new loginBLL();
        loginDTO lgnDTO = new loginDTO();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lgnDTO.Email = txtEmail.Text;
            lgnDTO.Senha = txtSenha.Text;

            if (lgnBLL.RealizarLogin(lgnDTO) == true)
            {
                Frm_Filmes frm_filmes = new Frm_Filmes();
                frm_filmes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLabEsq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11901071@aluno.cotemig.com.br", "lyvztyiysldnrfxk"),
                EnableSsl = true
            };
            lgnDTO.Email = txtEmail.Text;
            string senha = lgnBLL.RetornarSenha(lgnDTO);
            if (senha != "false")
            {
                client.Send("11901071@aluno.cotemig.com.br", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu email é {txtEmail.Text} com senha {senha}");
                MessageBox.Show("Email ou senha enviados.", "Recuperação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Email não cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
