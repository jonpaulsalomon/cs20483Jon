using CS20486.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curso 20483 asd");

            VRTypes types = new VRTypes();
            //types.Execute();

            TypesByValue typesByValue = new TypesByValue();
            typesByValue.Execute();

            Console.ReadKey();
        }
    }
}
