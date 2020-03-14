using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula8
{
    public class CapturarETratamento
    {
        public void Executa()
        {
            Calc calculadora = new Calc() { n1 = 1, n2 = 0 };
            calculadora.Divide();
        }
    }

    public class Calc
    {
       public int n1 { get; set; }
       public int n2 { get; set; }

        public int Soma()
        {
            return n1 + n2;
        }
        public int Subtrai()
        {
            return n1 - n2;
        }
        public int Divide()
        {
            int resultado = 0;
            try
            {
                resultado = n1 / n2;
            }
            catch
            {

            }
            return resultado;
            
        }

        public int Multiplicacao()
        {
            return n1 * n2;
        }
    }
}
