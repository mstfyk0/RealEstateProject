using Domain.Models;
using Domain.RequestParameters;


namespace Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct(bool trackChnages);
        IEnumerable<Product> GetAllProductsWithDetails (ProductRequestParameters p);
        Product? GetOneProduct(int id, bool trackChnages);
    }
}