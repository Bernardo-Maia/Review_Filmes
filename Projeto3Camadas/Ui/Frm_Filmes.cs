using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
namespace Projeto3Camadas
{
    public partial class Frm_Filmes : Form
    {
        FilmeBLL filbll = new FilmeBLL();
        FilmeDTO fildto = new FilmeDTO();

        public Frm_Filmes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fildto.Filme = txtFilme.Text;
            fildto.Desc = txtDesc.Text;
            filbll.Inserir(fildto);
            MessageBox.Show("Cadastro com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
