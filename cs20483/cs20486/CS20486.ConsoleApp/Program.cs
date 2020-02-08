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
            Console.WriteLine("Curso 20483");

            VRTypes types = new VRTypes();
            //types.Execute();

            TypesByValueInteger typesByValueInteger = new TypesByValueInteger();
            typesByValueInteger.Execute();

            TypesByValueFloat typesByValueFloat = new TypesByValueFloat();
            typesByValueFloat.Execute();

            Console.ReadKey();
        }
    }
}
