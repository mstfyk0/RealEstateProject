using Domain.Models;

namespace Application.Interfaces
{
    public interface IProductFeatureRepository : IRepositoryBase<ProductFeature>
    {
         IEnumerable<ProductFeature> GetListProductFeature(short productFeatureGroupId, bool trackChnages);
    }
}