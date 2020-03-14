using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    // --- Public, Private , Internal, Static, Protected
    // --- Modificador padrão durante a criação da classe = Internal
    public class Pessoa : Base
    {
        // --- Propriedade do tipo string (atalho prop + 2x tacla tab)
        // --- String  = Tipo por referência
        public string Nome { get; set; }

    }
}
