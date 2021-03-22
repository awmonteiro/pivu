using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Pedido_Itens
    {
        public int ID_PEDIDO_ITEM { get; set; }
        public int QUANTIDADE { get; set; }
        public int PEDIDO_ID_PEDIDO { get; set; }
        public int PRODUTO_ID_PRODUTO { get; set; }
    }
}
