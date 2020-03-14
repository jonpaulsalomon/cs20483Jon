using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class Delegados : Aulas
    {
        public void Executa()
        {
            Console.WriteLine("Delegates");
            Console.WriteLine("Tipo de dado por referencia");
            int num = 4;
            int exp = 3;
            Expoente conta = Quadrado;
            if (exp == 2)
            {
                conta = Quadrado;
            }
            else if (exp == 3)
            {
                conta = Cubo;
            }           
          

            Console.WriteLine($"O quadrado de {num} é {conta(num)}");
            //Console.WriteLine($"O cubo de {num} é {conta(num)}");

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
        private int Soma(int numero, int numero2)
        {
            return numero + numero2;
        }
    }
}
