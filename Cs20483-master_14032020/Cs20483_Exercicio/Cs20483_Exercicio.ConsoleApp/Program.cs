using Cs20483_Exercicio.Data.Repository;
using Cs20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoRepository repositorio = new ProdutoRepository();

            Produto produto = new Produto { 
                                            Nome="Nokia"
                                            , Descricao="Indestrutivel, bateria infinita"
                                            , Codigo="JP1995"
                                            , PrecoUnitario=1000.00m 
                                        };
            repositorio.Create(produto);
            var prodUpdate = repositorio.GetById(4);
            prodUpdate.Nome = "Iphone";
            prodUpdate.Descricao = "Destrutivel, sem bateria";

            //repositorio.Update(prodUpdate);
            //repositorio.Delete(4);

            foreach ( var item in repositorio.ListAll() )
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
