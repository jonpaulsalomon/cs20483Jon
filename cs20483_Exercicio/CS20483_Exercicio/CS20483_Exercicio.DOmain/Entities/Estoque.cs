using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483_Exercicio.Domain.Entities
{
    public class Estoque : Base
    {
        public Produto Produto { get; set; }

        public int Quantidade{ get; set; }
    }
}
