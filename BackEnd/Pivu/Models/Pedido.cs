using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Pedido
    {
        public int ID_PEDIDO { get; set; }
        public string STATUS { get; set; }
        public int USUARIO_ENDERECO_ID_ENDERECO { get; set; }
        public string ENTREGA_IMEDIATA { get; set; }
        public DateTime DATA_ENTREGA { get; set; }
        public string PAGO { get; set; }
        public DateTime DATA_PEDIDO { get; set; }
        public DateTime DATA_FECHAMENTO { get; set; }
        public int NOTA { get; set; }
        public int TIPO_PAGAMENTO_PEDIDO_ID_TIPO_PAGAMENTO { get; set; }
        public string USUARIO_ID_USUARIO { get; set; }
    }
}
