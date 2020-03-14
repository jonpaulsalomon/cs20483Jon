using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Interfaces
{
    public interface IRepository<T>
    {
        List<T> ListAll();
        T GetById(int id);
        string Create(T model);
        string Update(T model);
        string Delete(int id);
    }
}
