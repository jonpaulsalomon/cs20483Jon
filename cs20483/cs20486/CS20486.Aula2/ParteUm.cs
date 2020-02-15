using System;
using System.Collections.Generic;
using System.Text;

namespace CS20486.Aula2
{
    class ParteUm
    {
        public static void Execute()
        {
            int numero;
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa("asd");
            pessoa.Nome = "Joselito";
            pessoa.Sobrenome = "Silva";
            pessoa.Idade = 100;

            string pessoaRetornada = pessoa.FormatarParaSalvar();
            Console.WriteLine(pessoaRetornada);

            string pessoaFOrmadataComOutroSeparador = pessoa.FormatarParaSalvar('_');
            Console.WriteLine(pessoaFOrmadataComOutroSeparador);
        }
    }
}
