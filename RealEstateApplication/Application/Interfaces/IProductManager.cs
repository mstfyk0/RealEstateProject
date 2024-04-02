using Application.Dtos;
using Application.Queries;
using Domain.Common.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductManager
    {
        Task<PagedResponse<IEnumerable<ProductDto>>> GetList(GetAllProductQuery getAllProductQuery);
        Task<Response<ProductByIdDto>> GetById(GetProductByIdQuery getProductById);
    }
}
