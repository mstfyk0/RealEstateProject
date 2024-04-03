using Application.Interfaces;
using Domain.Models;

namespace Application.Manager
{
    
    public class ProductFeatureGroupManager : IProductFeatureGroupServices
    {

    private readonly  IRepositoryManager _manager;

        public ProductFeatureGroupManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<ProductFeatureGroup> GetAllProductFeatureGroup(bool trackChanges)
        {
            return _manager.ProductFeatureGroup.FindAll(trackChanges);
        }
    }
}