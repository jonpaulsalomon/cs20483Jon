using System;
using System.Collections.Generic;
using System.Text;

namespace CS20486.Aula2
{
    static class MetodosExtensions
    {
        public static void Imprimir(this Pessoa nome)
        {
            Console.WriteLine(nome);
        }
    }
}
