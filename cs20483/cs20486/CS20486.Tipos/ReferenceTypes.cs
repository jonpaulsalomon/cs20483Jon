using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class ReferenceTypes : IAulas
    {
        public void Execute()
        {
            Console.WriteLine("Reference type");
            PessoaClass pessoa1 = new PessoaClass()
            {
                Nome = "Chimbinha",
                Idade = 18
            };
            Console.WriteLine($"Pessoa1: {pessoa1}");

            var p2 = new PessoaClass();
            p2.Idade = 10;
            // === Object é tipo por referencia 
            Console.WriteLine($"dynamic p5 idade : {p2.Idade}");
            object p3 = new PessoaClass();
            //p3.Idade = 10;
            // === var é tipo por referencia 
            Console.WriteLine($"dynamic p5 idade : {p3}");
            var p4 = new PessoaClass();
            p4.Idade = 10;
            Console.WriteLine($"dynamic  idade : {p4.Idade}");
            // === dynamic
            dynamic p5 = new PessoaClass();
            p5.Idade = 10;
            Console.WriteLine($"dynamic p5 idade : {p5.Idade}");

            // STRING É TIPO POR REFERENCIA POR REFERICIAS O ENDEREÇO DOS SUBOBJETOS CHAR 
            string nome1 = "Jonathan";
            string nome2 = nome1;
            Console.WriteLine($"{nome1} - {nome2}");
            nome1 = "Doe";
            Console.WriteLine($"{nome1} - {nome2}");
            Console.WriteLine($"{nome1[0]}");

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

    interface Cadastro
    {

    }

}
