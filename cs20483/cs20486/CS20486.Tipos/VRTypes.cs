using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class VRTypes
    {
        public void Execute()
        {
            Console.WriteLine("tipos:");

            Console.WriteLine("tipos por valor");
            //cria um valor na memória
            int numero1 = 110;
            int numero2 = numero1;
            //modo comum: Console.WriteLine("valores inteiros: " + numero1 + " e " + numero2);
            // interpolação de strings
            Console.WriteLine($"valores inteiros: {numero1} e {numero2}");
            numero1 = 120;
            Console.WriteLine($"valores inteiros: {numero1} e {numero2}");

            Console.WriteLine("tipos por referência");
            // cria uma referência 
            Pessoinha pessoa1 = new Pessoinha { Idade = 10, Nome = "Jonathan" };
            Pessoinha pessoa2 = pessoa1;
            Console.WriteLine($"Pessoas: {pessoa1.Nome}-{pessoa1.Idade} --- {pessoa2.Nome}-{pessoa2.Idade}");
            pessoa1.Nome = "Zé";
            pessoa1.Idade = 20;
            Console.WriteLine($"Pessoas: {pessoa1.Nome}-{pessoa1.Idade} --- {pessoa2.Nome}-{pessoa2.Idade}");
        }        
    }
    public class Pessoinha
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
