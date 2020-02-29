using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Aula6
{
    interface IAnimal
    {
        byte Idade { get; set; }
        string Cor { get; set; }
        string Sexo { get; set; }

        void Comer();
        void Dormir();
    }
}
