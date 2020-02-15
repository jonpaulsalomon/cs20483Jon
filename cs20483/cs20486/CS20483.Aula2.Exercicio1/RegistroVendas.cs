using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS20483.Aula2.Exercicio1
{
    public class RegistroVendas
    {
        public List<VendaProdutos> Vendas { get; set; }
        private decimal Comissao { get; set; }

        public RegistroVendas()
        {
            this.Vendas = new List<VendaProdutos>();
        }

        public void CadastraVenda(Vendedor vendedor, Produto produto, int quantidadeVenda)
        {
            var vendasVendedor = Vendas.FirstOrDefault(v => v.Vendedor.Nome == vendedor.Nome);

            if (vendasVendedor != null)
            {
                vendasVendedor.produtosQuantidade.Add(new ProdutoQuantidade()
                {
                    Produto = produto,
                    Quantidade = quantidadeVenda
                });
            }
            else
            {
                Vendas.Add(new VendaProdutos()
                {
                    Vendedor = vendedor,
                    produtosQuantidade = new List<ProdutoQuantidade>()
                    {
                        new ProdutoQuantidade()
                        { 
                            Produto = produto,
                            Quantidade = quantidadeVenda
                        }
                    }
                });
            }          
        }

        public void ImprimirRelatorioDeVendasEComissao()
        {
            Console.WriteLine("*********Relatório de vendas e comissão*************");
            Console.WriteLine();

            foreach (var venda in Vendas)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($"Vendedor: {venda.Vendedor.Nome} {venda.Vendedor.Sobrenome}");
                Console.WriteLine();
                decimal totalvendido = 0;
                foreach (var produtosQuantidade in venda.produtosQuantidade)
                {
                    totalvendido += produtosQuantidade.Quantidade * produtosQuantidade.Produto.Preco_unitario;
                    Console.WriteLine($"    Produto: {produtosQuantidade.Produto.Nome} - Quantidade: {produtosQuantidade.Quantidade}");
                }
                Console.WriteLine();
                Console.WriteLine($"Total Vendiddo: R${totalvendido}");
                Console.WriteLine($"Comissão: R${totalvendido * (Comissao /100)}");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine();

            }      
        }

        public void RegistraComissao(decimal comissao)
        {
            Comissao = comissao;
        }
    }
}
