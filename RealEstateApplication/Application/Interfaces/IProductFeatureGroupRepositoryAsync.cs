using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductFeatureGroupRepositoryAsync : IGeneralRepositoryAsync<ProductFeatureGroup>
    {
        public Task<IEnumerable<ProductFeatureGroup>> GetAllWithEntityAsync();
    }
}
