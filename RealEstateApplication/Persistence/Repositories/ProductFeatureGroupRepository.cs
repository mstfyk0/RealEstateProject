using Application.Interfaces;
using Domain.Models;

namespace Persistence.Repositories
{
    public class ProductFeatureGroupRepository : RepositoryBase<ProductFeatureGroup>
    , IProductFeatureGroupRepository
    {
        public ProductFeatureGroupRepository(RepositoryContext context) : base(context)
        {

        }
    }
}