using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;
using System.Data;

namespace Projeto3Camadas.Code.BLL
{
    class loginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_login";
        public bool RealizarLogin(loginDTO login) 
        {
            string sql = $"select * from {tabela} where email = '{login.Email}' and senha = '{login.Senha}';";
            DataTable dt = conexao.ExecutarConsulta(sql);
            if (dt.Rows.Count > 0) return true;
            else return false;
        
        }
        public string RetornarSenha(loginDTO login)
        {
            string sql = $"select * from {tabela} where email ='{login.Email}';";
            DataTable dt = conexao.ExecutarConsulta(sql);
            if (dt.Rows.Count > 0) return dt.Rows[0]["senha"].ToString();
            else return "false";
        }
    }
}
