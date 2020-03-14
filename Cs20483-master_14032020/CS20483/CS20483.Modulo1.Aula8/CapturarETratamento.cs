using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

    public class CalcExpection : Exception
    {
        public CalcExpection(){}
        public CalcExpection(string message) : base(message){}
        public CalcExpection(string message, Exception innerException) : base(message, innerException){}
        protected CalcExpection(SerializationInfo info, StreamingContext context) : base(info, context){}
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
             if(this.n2 == 0)
                {
                    throw new CalcExpection("NAOOOOOOOOOO ZERO");
                }
                resultado = n1 / n2;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return resultado;
            
        }

        public int Multiplicacao()
        {
            return n1 * n2;
        }
    }
}
