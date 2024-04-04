using Application.Interfaces;

namespace Application.Manager
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService ;
        private readonly IProductFeatureGroupServices _productFeatureGroupService;
        private readonly IProductFeatureServices _productFeatureServices;


        public ServiceManager(IProductService productService, IProductFeatureGroupServices productFeatureGroupService
                            , IProductFeatureServices productFeatureServices)
        {
            _productService = productService;
            _productFeatureGroupService = productFeatureGroupService;
            _productFeatureServices = productFeatureServices;
        }

        public IProductService ProductService => _productService;

        public IProductFeatureGroupServices ProductFeatureGroupServices => _productFeatureGroupService;

        public IProductFeatureServices ProductFeatureServices => _productFeatureServices;
    }
}