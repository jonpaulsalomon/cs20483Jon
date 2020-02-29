using System.Collections.Generic;

namespace CS20483_Exercicio.Domain.Interfaces
{
    public interface IService<T> where T: class
    {
        T Get(int id);
        List<T> GetAll();
        string Post(T model);
        string Put(T model);
        string Delete(T model);
    }
}
