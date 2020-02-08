using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class OthersTypes : IAulas
    {
        public void Execute()
        {
            Console.WriteLine("Outros tipos por valor");
            Console.WriteLine("Boolean");
            bool deMaior = true;
            bool deMenor = false;
            byte n1 = 10;
            byte n2 = 2;
            bool par = (n1 % n2 == 0);
            Console.WriteLine($"O resto da divisão entre {n1} e {n2} é {n1 % n2}");
            Console.WriteLine($"O resto da divisão entre {n1} e {n2} é igual a 0? {par}");

            DiasFinalSemana diafinalSemana = (DiasFinalSemana)3;
            Console.WriteLine($"diafinalSemana: {diafinalSemana} ");
        }

        [Flags]
        public enum DiasFinalSemana
        {
            sabado = 1,
            domingo = 2
        }
    }
}
