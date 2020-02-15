using System;
using System.Collections.Generic;
using System.Text;

namespace CS20483.Aula2
{
    class ParteTres
    {
        public static void Executa()
        {
            var sala = new SalaAula();
            var pessoa1 = new Pessoa()
            {
                Nome = "Jonathan",
                Sobrenome = "Salomon"
            };

            sala["A"] = pessoa1;

            Console.WriteLine(sala["A"]);

        }
    }
}
