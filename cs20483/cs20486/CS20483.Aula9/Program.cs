using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Aula9
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            //decimal salarioLiquido = funcionario.CalculaSalarioLiqueido(5000.98m);
            //Console.WriteLine(salarioLiquido);

            Pessoa p = new Pessoa(0);
            
            for (int i = 1; i < 10000; i++)
            {
                p = new Pessoa(i);                
            }
                            
            Console.ReadKey();           
        }
    }
}
