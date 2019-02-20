using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.responsitory
{
    public interface IResponsitory<T> where T:class
    {
        IEnumerable<T> GetAllWidthProducts();
        IEnumerable<T> Find(Func<T,bool>predicate);
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Func<T, bool> predicate);
    }
}
