using CS20483_Exercicio.Data.Context;
using CS20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483_Exercicio.Data.Repository
{
    public class ProdutoRepository
    {
        public List<Produto> ListAll()
        {
            List<Produto> list = new List<Produto>();
            using (Cs20483Context context = new Cs20483Context())
            {
                list = context.Produto.ToList();
            }

            return list;
        }

        public Produto GetById(int id)
        {
            var model = new Produto();
            using (Cs20483Context context = new Cs20483Context())
            {
                model = context.Produto.Find(id);
                //model = context.Produto.FirstOrDefault(p => p.Id == id);
            }

            return model;
        }

        public string Create(Produto model)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Produto.Add(model);
                context.SaveChanges();
            }

            return "Inserido com sucesso";
        }

        public string Update(Produto model)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Entry<Produto>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado com sucesso";
        }

        public string Delete(int id)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Produto.Remove(GetById(id));
                context.SaveChanges();
            }

            return "Deletado com sucesso";
        }
    }

}
