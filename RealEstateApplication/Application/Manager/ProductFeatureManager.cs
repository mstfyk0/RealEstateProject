using Application.Interfaces;
using Domain.Models;

namespace Application.Manager
{
    public class ProductFeatureManager : IProductFeatureServices
    {

        private readonly IRepositoryManager _manager;

        public ProductFeatureManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<ProductFeature> GetAllProductFeature(  bool trackChanges)
        {
            return _manager.ProductFeature.FindAll(trackChanges);
        }

        public  IEnumerable<ProductFeature> GetListProductFeature(short productFeatureGroupId, bool trackChnages)
        {
            var product = _manager.ProductFeature.GetListProductFeature(productFeatureGroupId, trackChnages);
            if (product is null)
            {

                throw new Exception("Product feature Not Found!");

            }
            return product;
        }
    }
}