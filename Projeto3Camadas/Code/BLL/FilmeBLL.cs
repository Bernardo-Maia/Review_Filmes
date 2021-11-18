using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;
namespace Projeto3Camadas.Code.BLL
{
    class FilmeBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_filme";


        public void Inserir(FilmeDTO fildto)
        {
            string inserir = $"insert into {tabela} values (null, '{fildto.Filme}','{fildto.Desc}')";
            conexao.ExecutarComando(inserir);
        }
        public void Editar(FilmeDTO fildto)
        {

        }
        public void Excluir(FilmeDTO fildto)
        {

        }
        public void Listar(FilmeDTO fildto)
        {

        }
    }
}
