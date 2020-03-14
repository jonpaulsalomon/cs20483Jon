using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class TipoReferencia : Aulas
    {
        public void Executa()
        {
            Console.WriteLine("Tipos por referencia - Classe");
            PessoaClasse p = new PessoaClasse { Nome="Chimba", Idade=30 };
            Console.WriteLine($"Class Pessoa: {p}");

   
            // === Object é tipo por referÊncia
            object p3 = new PessoaClasse { Idade = 10};
            
            Console.WriteLine($"Pessoa idade com object {p3}");
            // === Var é tipo por referência
            var p4 = new PessoaClasse();
            p4.Idade = 10;
            Console.WriteLine($"Pessoa idade com var {p4.Idade}");
            // === Dynamic -
            dynamic p5 = new PessoaClasse();
            p5.Idade = 10;
            //p5.Cpf = "05315616516";
            Console.WriteLine($"Pessoa idade com dynamic {p5.Idade}");

            //====== String é tipo por referencia por referenciar endereco dos subobjetos char

            string nome1 = "Maykon";
            string nome2 = nome1;
            Console.WriteLine($"{nome1}-{nome2}");
            nome1 = "Chimba";
            Console.WriteLine($"{nome1}-{nome2}");
            //==== pegando uma posicao do vetor de caracteres (string)
            Console.WriteLine($"{nome1[0]}");
        }
    }
    public class PessoaClasse
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{this.Nome}-{this.Idade}";
        }

    }



}
