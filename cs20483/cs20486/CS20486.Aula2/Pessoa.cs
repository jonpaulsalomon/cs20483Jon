using System;
using System.Collections.Generic;
using System.Text;

namespace CS20486.Aula2
{
    class Pessoa
    {
        //properties
        public static string cpf;
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa()
        {
            //Console.WriteLine("Passando pelo construtor");
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        //methods
        public string FormatarParaSalvar()
        {
            string pessoaFormatada = $"{Idade};{Nome};{Sobrenome}";
            return pessoaFormatada;
        }

        public string FormatarParaSalvar(char separador)
        {
            string pessoaFormatada = $"{Idade}{separador}{Nome}{separador}{Sobrenome}";
            return pessoaFormatada;
        }


    }
}
