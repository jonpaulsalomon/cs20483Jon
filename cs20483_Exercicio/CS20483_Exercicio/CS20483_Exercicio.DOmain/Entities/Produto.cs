﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483_Exercicio.Domain.Entities
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome{ get; set; }
        public string Descricao{ get; set; }
        public decimal PrecoUnitario{ get; set; }
    }
}
