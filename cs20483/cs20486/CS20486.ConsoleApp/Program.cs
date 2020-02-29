using CS20483.Modulo1.Aula6;
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
            //Console.WriteLine("Curso 20483");
            //Console.WriteLine("");

            // VRTypes types = new VRTypes();
            // //types.Execute();

            // TypesByValueInteger typesByValueInteger = new TypesByValueInteger();
            // // typesByValueInteger.Execute();

            // TypesByValueFloat typesByValueFloat = new TypesByValueFloat();
            // //typesByValueFloat.Execute();

            // Structs structs = new Structs();
            // //structs.Execute();

            // ReferenceTypes referenceTypes = new ReferenceTypes();
            //// referenceTypes.Execute();

            // UsingTypes usingTypes = new UsingTypes();
            // //usingTypes.Execute();

            // OthersTypes othersTypes = new OthersTypes();
            // //othersTypes.Execute();

            // Delegates delegates = new Delegates();
            // //delegates.Execute();

            //TesteComparacao t = new TesteComparacao();
            //t.Executa();

            TesteComparacaoListas t = new TesteComparacaoListas();
            t.Executa();

            Console.ReadKey();
        }
    }

  
}
