using Domain.Models;


namespace Application.Interfaces
{
    public interface IProductFeatureServices
    {
        IEnumerable<ProductFeature> GetAllProductFeature(bool trackChanges);
        IEnumerable<ProductFeature> GetListProductFeature(short productFeatureGroupId, bool trackChnages);
    }
}