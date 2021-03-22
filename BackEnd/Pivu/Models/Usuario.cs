using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Usuario
    {
        public string ID_USUARIO { get; set; }
        public string NOME { get; set; }
        public int CPF { get; set; }
        public DateTime NASCIMENTO { get; set; }
        public int ID_ENDERECO_PRINCIPAL { get; set; }
        public string EMAIL { get; set; }
        public string PHONENUMBER { get; set; }
    }
}
