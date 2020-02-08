using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class TypesByValueFloat : IAulas
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

            double n1 = 9.10;
            double n2 = 1.20;
            double total = 10.30;
            Console.WriteLine($"(COM DOUBLE) A soma de 9.10 + 1.2 é {n1+n2}");
            Console.WriteLine($"(COM DOUBLE) verificando se {total} é igual  a {n1+n2} : {total == (n1+n2)}");

            decimal n1d = 9.10m;
            decimal n2d = 1.20m;
            decimal totald = 10.30m;
            Console.WriteLine($"(COM DECIMAL) A soma de 9.10 + 1.2 é {n1d + n1d}");
            Console.WriteLine($"(COM DECIMAL) verificando se {totald} é igual  a {n1d + n2d} : {totald == (n1d + n2d)}");
        }
    }
}
