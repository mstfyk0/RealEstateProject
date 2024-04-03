using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct(bool trackChnages);
        IEnumerable<Product> GetLastestProduct( int n ,bool trackChnages);
        IEnumerable<Product> GetAllProductsWithDetails (ProductRequestParameters p);
        IEnumerable<Product> GetShowCaseProducts(bool trackChange);
        Product? GetOneProduct(int id, bool trackChnages);
    }
}