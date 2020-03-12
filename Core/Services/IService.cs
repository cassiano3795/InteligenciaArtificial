using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Services
{
    public interface IService<T> : IDisposable where  T: class
    {
        T Create(T entity);
        T Read(int id);
        T Update(T entity);
        bool Delete(int id);

        void SaveChanges();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
