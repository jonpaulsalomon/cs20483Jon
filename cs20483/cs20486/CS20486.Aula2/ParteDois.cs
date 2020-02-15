using System;
using System.Collections.Generic;
using System.Text;

namespace CS20486.Aula2
{
    class ParteDois
    {
        public static void Execute()
        {
            // estanciando uma variavel do tipo pessoa ( objeto )
            // new - instancia o objeto e chama o construtor ( no caso sem parametros)
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "nome 1";
            pessoa1.Sobrenome= "sobrenome 1";
            
            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "nome 2";
            pessoa2.Sobrenome = "sobrenome 2";

            Pessoa pessoa3 = new Pessoa();
            //parametros nomeados
            pessoa3.CarregaPessoa(idade: 10, nome: "John", sobrenome: "Doe");
            //parametro opcional idade 
            pessoa3.CarregaPessoa("John","Doe");
            // chamada de metodo com parametro opcional e noemeado
            pessoa3.CarregaPessoa("John",idade:99);

            Metodos.Imprimir("Josue");
            Metodos.Imprimir(18);
            Metodos.Imprimir(pessoa1);


            //Console.WriteLine(pessoa1.FormatarNomeComppleto());
            //string nome1 = pessoa1.FormatarNomeComppleto(pessoa1);
            //string nome2 = pessoa2.FormatarNomeComppleto(pessoa2.Nome, pessoa2.Sobrenome);
            //Console.WriteLine(nome1);
            //Console.WriteLine(nome2);
        }
        Metodos
    }
}
