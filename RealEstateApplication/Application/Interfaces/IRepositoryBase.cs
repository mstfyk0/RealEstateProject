using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IRepositoryBase<T>
    {

        IQueryable<T> FindAll(bool trackChange);
        T? FindByCondition(Expression<Func<T,bool>> expression, bool trackChange);
    }
}