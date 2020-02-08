using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class UsingTypes
    {
        public void Execute()
        {
            Console.WriteLine("Conversão de tipos valor");
            byte n1 = 10;
            short n2 = 10;
            long n3 = 20;
            short n4 = 30;
            //var - tipo definido durante a atribuição
            var result = n1 + n2;
            var res2 = n3 + n4;

            // object é o tipo mais básico do c#
            object res3 = n3 + n1;
            
            Console.WriteLine($"A soma é { result } - e resulta em um '{result.GetType()}'");
            Console.WriteLine($"A soma 2 é { res2 } - e resulta em um '{res2.GetType()}'");
            Console.WriteLine($"A soma 3 é { res3 } - e resulta em um '{res3.GetType()}'");
        }
    }
}
