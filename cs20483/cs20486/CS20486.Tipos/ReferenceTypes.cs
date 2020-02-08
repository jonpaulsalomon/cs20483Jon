using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class ReferenceTypes
    {
        public void Execute()
        {
            Console.WriteLine("Reference type");
            object pessoa = new PessoaClass()
            {
                Nome = "Chimbinha",
                Idade = 18
            };

            Console.WriteLine($"Pessoa: {pessoa}");

            //PessoaClass p = new PessoaClass
            //{
            //    Nome = "Chimbinha",
            //    Idade = 18
            //};
            //PessoaClass p2 = p;
            //Console.WriteLine($" PessoaStruct {p.Nome}-{p.Idade} -- {p2.Nome}-{p2.Idade}");
            //p.Nome = "Joelma";
            //p.Idade = 19;
            //Console.WriteLine($" PessoaStruct {p.Nome}-{p.Idade} -- {p2.Nome}-{p2.Idade}");
        }
    }

    public class PessoaClass
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome} - Idade: {this.Idade}";
        }
    }
}
