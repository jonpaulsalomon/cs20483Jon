using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class TypesByValue
    {
        public void Execute()
        {
            Console.WriteLine("Tipos por valor");
            Console.WriteLine("Tipos Integrais:");// inteiros
            byte num_byte = 10;
            int numero = 10;
            Console.WriteLine($"byte: min:{Byte.MinValue} max:{Byte.MaxValue}");
            Console.WriteLine($"Int32: min:{Int32.MinValue} max:{Int32.MaxValue}");
            



        }
    }
}
