using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {

        IQueryable<T> FindAll(bool trackChange);
        T? FindByCondition(Expression<Func<T,bool>> expression, bool trackChange);
    }
}