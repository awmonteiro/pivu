using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Cervejaria
    {
        public int ID_CERVEJARIA { get; set; }
        public string NOME { get; set; }
        public int TELEFONE { get; set; }
        public string EMAIL { get; set; }
        public int CNPJ { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
