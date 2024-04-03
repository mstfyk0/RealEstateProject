using Entities.Models;

namespace Services.Contracts
{
    public interface IProductFeatureGroupServices
    {
        IEnumerable<ProductFeatureGroup> GetAllCategories(bool trackChanges);
    }
}