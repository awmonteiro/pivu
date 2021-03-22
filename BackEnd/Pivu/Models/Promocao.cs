using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Promocao
    {
        public int ID_PROMOCAO { get; set; }
        public int PRECO { get; set; }
        public DateTime INICIO { get; set; }
        public DateTime FIM { get; set; }
        public int PRODUTO_ID_PRODUTO { get; set; }
    }
}
