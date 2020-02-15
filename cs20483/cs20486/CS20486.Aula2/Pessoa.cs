using System;
using System.Collections.Generic;
using System.Text;

namespace CS20483.Aula2
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

        public string FormatarNomeComppleto()
        {
            string nomeCompleto = $"{Nome} {Sobrenome}";
            return nomeCompleto;
        }

        public string FormatarNomeComppleto(Pessoa pessoa)
        {
            string nomeCompleto = $"{pessoa.Nome} {pessoa.Sobrenome}";
            return nomeCompleto;
        }

        public string FormatarNomeComppleto(string nome, string sobrenome)
        {
            string nomeCompleto = $"{nome} {sobrenome}";
            return nomeCompleto;
        }

        // parametros opcionals sempre os ultimos 
        public void CarregaPessoa(string nome , string sobrenome="sobrenome padrao", int idade=18)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"{this.Nome} {this.Sobrenome} {this.Idade}";
        }
    }
}

