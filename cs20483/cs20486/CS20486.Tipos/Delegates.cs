using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class Delegates : IAulas
    {
        public void Execute()
        {
            Console.WriteLine("DElegates");
            Console.WriteLine("Tipo de dado por referencia");
            int num = 4;
            int expoente = 3;
            Expoente conta;

            if (expoente == 2)
            {
                conta = Quadrado;
            }
            else
            {
                conta = Cubo;
            }
            
            Console.WriteLine($"O cubo ou quadrado de {num} é {conta(4)}");            
        }

        delegate int Expoente(int numero);

        private int Quadrado(int numero)
        {
            return numero * numero;
        }
        private int Cubo(int numero)
        {
            return numero * numero * numero;
        }

    }
}
