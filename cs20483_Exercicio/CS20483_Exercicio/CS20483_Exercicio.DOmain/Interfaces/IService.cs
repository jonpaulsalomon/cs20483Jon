using System.Collections.Generic;

namespace CS20483_Exercicio.Domain.Interfaces
{
    public interface IService<T> where T: class
    {
        T Get(int id);
        List<T> GetAll();
        string Post(T entidade);
        string Put(T entidade);
        string Delete(T entidade);
    }
}
