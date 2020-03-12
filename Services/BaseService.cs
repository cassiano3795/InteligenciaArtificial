using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Services;
using IADB.Context;

namespace Services
{
    public class BaseService<T> : IService<T> where T : class
    {
        private readonly Context _context;
        public BaseService(Context context)
        {
            _context = context;
        }
        public T Create(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                return entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public T Read(int id)
        {
            try
            {
                var entity = _context.Set<T>().Find(id);
                return entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public T Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                return entity;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = Read(id);
                _context.Set<T>().Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            try
            {
                return _context.Set<T>().Where(expression);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
