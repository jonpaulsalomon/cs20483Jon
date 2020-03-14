using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.Interfaces
{
    interface IAnimalDomestico
    {
        string Apelido { get; set; }
        void Comer();
    }
}
