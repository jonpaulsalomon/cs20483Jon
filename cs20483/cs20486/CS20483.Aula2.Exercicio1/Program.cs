using System;

namespace CS20483.Aula2.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");

            var produto1 = new Produto() { Nome = "Capinha Amarela", Estoque = 10, Preco_unitario = 50 };
            var produto2 = new Produto() { Nome = "Capinha Roxa", Estoque = 10, Preco_unitario = 100 };

            var vendedor1 = new Vendedor() { Nome = "John", Sobrenome = "Doe" };
            var vendedor2 = new Vendedor() { Nome = "Joselito", Sobrenome = "Silva" };

            var registroVendas = new RegistroVendas();

            registroVendas.RegistraComissao(10);

            registroVendas.CadastraVenda(vendedor1,produto1, 1);
            registroVendas.CadastraVenda(vendedor1,produto1, 2);
            registroVendas.CadastraVenda(vendedor1,produto2, 3);     
            
            registroVendas.CadastraVenda(vendedor2, produto2, 1);
            registroVendas.CadastraVenda(vendedor2, produto2, 1);            


            registroVendas.ImprimirRelatorioDeVendasEComissao();

            Console.ReadKey();
        }
    }
}
