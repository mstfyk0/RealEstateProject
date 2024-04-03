using Domain.Models;


namespace Application.Interfaces
{
    public interface IProductFeatureGroupServices
    {
        IEnumerable<ProductFeatureGroup> GetAllProductFeatureGroup(bool trackChanges);
    }
}