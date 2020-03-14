using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class TiposVR
    {
        public void Executa()
        {
            Console.WriteLine("Tipos:");
            Console.WriteLine("Tipos por valor");
            int numero1 = 110;
            int numero2 = numero1;
            //Console.WriteLine("Valores inteiros: "+ numero1 + " e " + numero2);
            // ==== Interpolação de strings
            Console.WriteLine($"Valores inteiros: {numero1} e {numero2}");
            numero1 = 120;
            Console.WriteLine($"Valores inteiros: {numero1} e {numero2}");
            
            Console.WriteLine("Tipos por referência");
            Person pessoa1 = new Person { Idade = 10, Nome = "Maykon" };
            Person pessoa2 = pessoa1;
            Console.WriteLine($"Pessoas: {pessoa1.Nome}-{pessoa1.Idade} --- {pessoa2.Nome}-{pessoa2.Idade}");
            pessoa1.Nome = "Joao";
            pessoa1.Idade = 20;
            Console.WriteLine($"Pessoas: {pessoa1.Nome}-{pessoa1.Idade} --- {pessoa2.Nome}-{pessoa2.Idade}");



        }
    }
    public class Person 
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
