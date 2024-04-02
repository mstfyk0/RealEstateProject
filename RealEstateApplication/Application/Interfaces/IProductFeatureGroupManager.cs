using Application.Dtos;
using Domain.Common.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductFeatureGroupManager
    {
        Task<Response<IEnumerable<ProductFeatureGroupDto>>> GetList();
    }
}
