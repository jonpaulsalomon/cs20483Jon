using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class TypesByValueFloat
    {
        public void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("****** Tipos Flutuantes:");
            //5.9722 × 10 24 massa da terra
            float num_float = 5.9722e24f;
            Console.WriteLine($"massa terra: {num_float}");
            Console.WriteLine($"float: min:{Single.MinValue} max:{float.MaxValue}");

            //1,989 × 10^30 massa do sol
            double num_double = 1.989e30F;
            Console.WriteLine($"massa sol: {num_double}");
            Console.WriteLine($"double: min:{Double.MinValue} max:{double.MaxValue}");

            // uso monetário
            decimal num_decimal = 4.578m;
            Console.WriteLine($"decimal: min:{decimal.MinValue} max:{decimal.MaxValue}");
            


        }
    }
}
