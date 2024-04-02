using Application.Queries;
using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductRepositoryAsync : IGeneralRepositoryAsync<Product>
    {
        Task<IEnumerable<Product>> GetBySearchAsync(GetAllProductQuery getAllProductQuery);
    }
}
