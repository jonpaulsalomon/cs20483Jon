using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            decimal salarioLiquido = funcionario.CalculaSalarioLiqueido(5000.98m);

            Console.WriteLine(salarioLiquido);
            Console.ReadKey();
        }
    }
}
