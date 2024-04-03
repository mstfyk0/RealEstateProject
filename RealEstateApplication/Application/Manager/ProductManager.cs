using AutoMapper;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public IEnumerable<Product> GetAllProduct(bool trackChnages)
        {
            // throw new NotImplementedException();
            return _manager.Product.GetAllProducts(trackChnages);
        }

        public IEnumerable<Product> GetAllProductsWithDetails(ProductRequestParameters p)
        {
            return _manager.Product.GetAllProductsWithDetails(p);
        }

        public IEnumerable<Product> GetLastestProduct(int n, bool trackChnages)
        {
            return _manager.Product.FindAll(trackChnages)
            .OrderByDescending(prd => prd.id)
            .Take(n);
        }

        public Product? GetOneProduct(int id, bool trackChnages)
        {

            var product = _manager.Product.GetOneProduct(id, trackChnages);
            if (product is null)
            {

                throw new Exception("Product Not Found!");

            }
            return product;
        }

        public IEnumerable<Product> GetShowCaseProducts(bool trackChange)
        {
           var product = _manager.Product.GetShowCaseProducts(trackChange);
           return product;
        }
    }
}