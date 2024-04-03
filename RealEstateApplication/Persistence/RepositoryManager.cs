
using Application.Interfaces;

namespace Persistence
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;
        private readonly IProductFeatureGroupRepository _productFeatureGroupRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context, IProductFeatureGroupRepository productFeatureGroupRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _productFeatureGroupRepository = productFeatureGroupRepository;
           
        }
        public IProductRepository Product
        => _productRepository;
        public IProductFeatureGroupRepository ProductFeatureGroup => _productFeatureGroupRepository;
    }
}