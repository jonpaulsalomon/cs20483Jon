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
            var list = new List<Produto>();

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
