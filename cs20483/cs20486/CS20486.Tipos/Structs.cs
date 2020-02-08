using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class Structs
    {
        public void Execute()
        {
            Console.WriteLine("Estruturas");
            PessoaStruct p = new PessoaStruct
            {
                Nome = "Chimbinha",
                Idade = 18
            };
            PessoaStruct p2 = p;
            Console.WriteLine($" PessoaStruct {p.Nome}-{p.Idade} -- {p2.Nome}-{p2.Idade}");
            p.Nome = "Joelma";
            p.Idade = 19;
            Console.WriteLine($" PessoaStruct {p.Nome}-{p.Idade} -- {p2.Nome}-{p2.Idade}");
        }
    }

    public struct PessoaStruct
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public PessoaStruct(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
