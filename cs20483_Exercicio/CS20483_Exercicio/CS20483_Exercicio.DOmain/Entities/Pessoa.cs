using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483_Exercicio.Domain.Entities
{
    // -- public private, internal , Static, Protected
    // -- Modificador padrão durante a criação da classe = internal
    public class Pessoa : Base
    {
        // --- Propriedade do tipo string
        // --- string = tipo por referência
        public string Nome { get; set; }


    }
}
