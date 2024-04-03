using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    
    public class ProductFeatureGroupManager : IProductFeatureGroupServices
    {

    private readonly  IRepositoryManager _manager;

        public ProductFeatureGroupManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<ProductFeatureGroup> GetAllCategories(bool trackChanges)
        {
            return _manager.ProductFeatureGroup.FindAll(trackChanges);
        }
    }
}