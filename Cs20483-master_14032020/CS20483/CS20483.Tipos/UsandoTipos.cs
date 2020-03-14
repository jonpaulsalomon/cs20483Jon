using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class UsandoTipos
    {
        public void Execute()
        {
            Console.WriteLine("Conversao de tipos valor");
            byte n1 = 10;
            short n2 = 10;
            long n3 = 9_223_372_036_854_775_807;
            short n4 = 30;
            // === Var - tipo definido durante a atribuição
            var resultado = n1 + n2;
            var res2 = n3 + n4;
            
            //==== Tipo mais basico do C#, podemos converter qualquer tipo para ele
            object res3 = n3 + n1;

            // ==== Conversao Explicita / cast
            var res4 = (int)n3;
            var res5 = Convert.ToInt32(n3);
                       
            Console.WriteLine($"A soma é { resultado } - e resulta em tipo { resultado.GetType() }");
            Console.WriteLine($"A soma é { res2 } - e resulta em tipo { res2.GetType() }");
            Console.WriteLine($"A soma é { res3 } - e resulta em tipo { res3.GetType() }");
            Console.WriteLine($"A soma é { res4 } - e resulta em tipo { res4.GetType() }");
            Console.WriteLine($"A soma é { res5 } - e resulta em tipo { res5.GetType() }");
        }
    }
}
