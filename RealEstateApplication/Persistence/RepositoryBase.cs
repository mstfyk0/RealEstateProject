using System.Linq.Expressions;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
    where T : class, new()
    {
        protected readonly RepositoryContext _context;

        protected RepositoryBase(RepositoryContext context)
        {

            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public IQueryable<T> FindAll(bool trackChange)
        {
            return trackChange ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
        }

        public T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChange)
        {

            return trackChange ? _context.Set<T>().Where(expression).FirstOrDefault()
            : _context.Set<T>().Where(expression).AsNoTracking().FirstOrDefault() ;
        }

        public IQueryable<T>? FindByList(Expression<Func<T, bool>> expression, bool trackChange)
        {

            return trackChange ? _context.Set<T>().Where(expression)
            : _context.Set<T>().Where(expression).AsNoTracking();
        }


        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }

}