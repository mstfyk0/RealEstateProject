using Application.Interfaces;
using Domain.Models;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    public class ProductFeatureRepository : RepositoryBase<ProductFeature>
   , IProductFeatureRepository
    {
        public ProductFeatureRepository(RepositoryContext context) : base(context)
        {

        }
        public  IEnumerable<ProductFeature> GetListProductFeature(short productFeatureGroupId, bool trackChnages)
        {
            return FindByList(p => p.productFeatureGroupId.Equals(productFeatureGroupId), trackChnages);
        }
    }
}