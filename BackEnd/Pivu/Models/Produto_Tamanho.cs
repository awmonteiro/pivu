using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Produto_Tamanho
    {
        public int PRODUTO_ID_PRODUTO { get; set; }
        public int TAMANHO_ID_TAMANHO { get; set; }
        public double PRECO { get; set; }
        public int QUANTIDADE { get; set; }

        public List<Produto> Produtos { get; set; }
        public List<Tamanho> Tamanhos { get; set; }
    }
}
