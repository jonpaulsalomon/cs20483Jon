using Cs20483_Exercicio.Data.Context;
using Cs20483_Exercicio.Domain.Entities;
using Cs20483_Exercicio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T: Base
    {
        public List<T> ListAll()
        {
            List<T> list;
            using (Cs20483Context context = new Cs20483Context())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }
        public T GetById(int id)
        {
            T model;
            using (Cs20483Context context = new Cs20483Context())
            {
                model = context.Set<T>().Find(id);
                // --- Filtro por id usando 
                //model = context.Produto.Where(p=>p.Id==id).FirstOrDefault();
            }
            return model;
        }
        public string Create(T model)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
            return "Inserido com sucesso";
        }
        public string Update(T model)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado com sucesso";
        }
        public string Delete(int id)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                T model = GetById(id);
                context.Entry<T>(model).State = EntityState.Deleted;
                context.Set<T>().Remove(model);
                context.SaveChanges();
            }
            return "Deletado com sucesso";
        }
    }
}
