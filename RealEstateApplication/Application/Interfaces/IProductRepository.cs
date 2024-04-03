
using Domain.Models;
using Domain.RequestParameters;

namespace Application.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts (bool trackChange);
        IQueryable<Product> GetAllProductsWithDetails (ProductRequestParameters p);
        Product? GetOneProduct(int id, bool trackChange);
    }
}