using System;
using System.Data;
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
            string alterar = $"update {tabela} set filme = '{fildto.Filme}', descricao = '{fildto.Desc}' where id = '{fildto.Id}';";
            conexao.ExecutarComando(alterar);
        }
        public void Excluir(FilmeDTO fildto)
        {
            string excluir = $"delete from {tabela} where id = '{fildto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
