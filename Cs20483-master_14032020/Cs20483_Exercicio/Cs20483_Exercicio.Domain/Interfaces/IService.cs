using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Interfaces
{
    interface IService<T>
    {
        T Get(int id);
        List<T> GetAll();
        string Post(T model);
        string Put(T model);
        string Delete(int id);
    }
}
