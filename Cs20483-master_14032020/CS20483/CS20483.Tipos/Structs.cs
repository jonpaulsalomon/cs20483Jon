using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class Structs
    {
        public void Executa()
        {
            Console.WriteLine("Estruturas");
            Pessoa p = new Pessoa();
            p.Nome = "Chimbinha";
            p.Idade = 18;
            Pessoa p2 = p;
            Console.WriteLine($"{p.Nome}-{p.Idade} -- {p2.Nome}-{p2.Idade}");
            p.Idade = 19;
            p.Nome = "Joelma";
            Console.WriteLine($"{p.Nome}-{p.Idade} -- {p2.Nome}-{p2.Idade}");
        }
    }
    public struct Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
       
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
