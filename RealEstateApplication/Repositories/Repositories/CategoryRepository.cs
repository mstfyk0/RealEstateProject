using Entities.Models;
using Repositories.Contracts;

namespace Repositories.Repositories
{
    public class CategoryRepository :
    RepositoryBase<Category>
    , ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {

        }
    }
}