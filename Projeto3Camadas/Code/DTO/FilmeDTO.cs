using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class FilmeDTO
    {
        private int _id;
        private string _filme;
        private string _desc;

        public int Id { get => _id; set => _id = value; }
        public string Filme { get => _filme; set => _filme = value; }
        public string Desc { get => _desc; set => _desc = value; }
    }
}
