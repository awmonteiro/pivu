using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Tamanho
    {
        public int ID_TAMANHO { get; set; }
        public int VOLUME { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
