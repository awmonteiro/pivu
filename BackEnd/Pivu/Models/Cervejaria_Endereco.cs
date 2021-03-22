﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Models
{
    public class Cervejaria_Endereco
    {
        public int ID_ENDERECO { get; set; }
        public int CEP { get; set; }
        public string RUA { get; set; }
        public int NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public int CERVEJARIA_ID_CERVEJARIA { get; set; }

    }
}
