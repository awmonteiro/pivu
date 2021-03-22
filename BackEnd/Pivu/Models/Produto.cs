using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Produto
    {
        public int ID_PRODUTO { get; set; }
        public string NOME { get; set; }
        public string ESTILO { get; set; }
        public string DESCRICAO { get; set; }
        public int IBU { get; set; }
        public int ABV { get; set; }        
        public int DIAS_PREPARO { get; set; }
        public int PROMOCAO_ID_PROMOCAO { get; set; }
        public int CERVEJARIA_ID_CERVEJARIA { get; set; }

        public Cervejaria Cervejaria { get; set; }
        
        public Tamanho Tamanho { get; set; }
        public List<Tamanho> Tamanhos { get; set; }
        public List<Produto_Tamanho> Produto_Tamanhos { get; set; }
    }
}
