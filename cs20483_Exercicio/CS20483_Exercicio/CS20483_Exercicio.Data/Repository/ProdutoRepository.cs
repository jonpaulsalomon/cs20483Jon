using CS20483_Exercicio.Data.Context;
using CS20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483_Exercicio.Data.Repository
{
    public class ProdutoRepository
    {
        public List<Produto> ListAll()
        {
            Cs20483Context context = new Cs20483Context();
            List<Produto> list = context.Produto.ToList();
            context.Dispose();
            return list;
        }

        public Produto GetById(int id)
        {
            var model = new Produto();

            return model;
        }

        public string Create(Produto model)
        {

            return "Inserido com sucesso";
        }

        public string Update(Produto model)
        {
            return "Alterado com sucesso";
        }

        public string Delete(int id)
        {
            return "Deletado com sucesso";
        }
    }

}
