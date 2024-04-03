using Application.Interfaces;

namespace Application.Manager
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService ;
        private readonly IProductFeatureGroupServices _productFeatureGroupService;


        public ServiceManager(IProductService productService, IProductFeatureGroupServices productFeatureGroupService)
        {
            _productService = productService;
            _productFeatureGroupService = productFeatureGroupService;
        }

        public IProductService ProductService => _productService;

        public IProductFeatureGroupServices ProductFeatureGroupServices => _productFeatureGroupService;
    }
}