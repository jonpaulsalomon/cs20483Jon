using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class TiposValorFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Tipos por valor");

            Console.WriteLine("Tipos Flutuantes:");
            //5.9722 × 10 24
            float massa_terra = 5.9722e24f;
            Console.WriteLine($"Tipo Float:{Single.MinValue} - {float.MaxValue}");

            //1,989 × 10^30 kg
            double massa_sol = 1.989e30;
            Console.WriteLine($"Tipo Double:{Double.MinValue} - {double.MaxValue}");

            //==== Ponto flutuante para se trabalhar com valores monetários
            decimal dinheiro = 4.578m;
            Console.WriteLine($"Tipo Decimal:{Decimal.MinValue} - {decimal.MaxValue}");


            ///============================ Problema de arredondamento de double
            double n1 = 9.10;
            double n2 = 1.20;
            double total = 10.30;
            Console.WriteLine($"A soma de 9.10 + 1.20 é {n1+n2}");
            Console.WriteLine($"Verificando se {total} é igual a 10.30 {total == (n1 + n2)}");
            Console.WriteLine($"{(n1 + n2)}");

            decimal nd1 = 9.10m;
            decimal nd2 = 1.20M;
            decimal totald = 10.30m;

            Console.WriteLine($"A soma de 9.10 + 1.20 é {nd1 + nd2}");
            Console.WriteLine($"Verificando se {totald} é igual a 10.30 {totald == (nd1 + nd2)}");
            Console.WriteLine($"{(nd1 + nd2)}");
        }
    }
}
