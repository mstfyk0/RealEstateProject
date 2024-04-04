
using Application.Interfaces;

namespace Persistence
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;
        private readonly IProductFeatureRepository _productFeatureRepository;

        private readonly IProductFeatureGroupRepository _productFeatureGroupRepository;


        public RepositoryManager(IProductRepository productRepository, RepositoryContext context, IProductFeatureGroupRepository productFeatureGroupRepository, IProductFeatureRepository productFeatureRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _productFeatureGroupRepository = productFeatureGroupRepository;
            _productFeatureRepository = productFeatureRepository;
        }
        public IProductRepository Product
        => _productRepository;
        public IProductFeatureGroupRepository ProductFeatureGroup => _productFeatureGroupRepository;

        public IProductFeatureRepository ProductFeature => _productFeatureRepository;
    }
}