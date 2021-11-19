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
            MessageBox.Show("Cadastro com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filbll.Inserir(fildto);
            dgvFilme.DataSource = filbll.Listar();
            txtDesc.Clear();
            txtFilme.Clear();
            txtID.Clear();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            fildto.Id = int.Parse(txtID.Text);
            fildto.Filme = txtFilme.Text;
            fildto.Desc = txtDesc.Text;
            filbll.Editar(fildto);
            dgvFilme.DataSource = filbll.Listar();
            MessageBox.Show("Editado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDesc.Clear();
            txtFilme.Clear();
            txtID.Clear();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            fildto.Id = int.Parse(txtID.Text);
            filbll.Excluir(fildto);
            MessageBox.Show("Apagado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvFilme.DataSource = filbll.Listar();
            txtDesc.Clear();
            txtFilme.Clear();
            txtID.Clear();

        }

        private void Frm_Filmes_Load(object sender, EventArgs e)
        {
            dgvFilme.DataSource = filbll.Listar();

        }

        private void dgvFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvFilme.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFilme.Text = dgvFilme.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDesc.Text = dgvFilme.Rows[e.RowIndex].Cells[2].Value.ToString();

            
        }


       
    }
}
