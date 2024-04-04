using Domain.Models;
using Domain.RequestParameters;


namespace Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct(bool trackChnages);
        IEnumerable<Product> GetAllProductsWithDetails (ProductRequestParameters p);
        IEnumerable<Product> GetShowCaseProducts(bool trackChange);
        Product? GetOneProduct(int id, bool trackChnages);
    }
}