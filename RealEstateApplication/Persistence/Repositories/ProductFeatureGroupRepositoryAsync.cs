using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class ProductFeatureGroupRepositoryAsync : GeneralRepositoryAsync<ProductFeatureGroup>, IProductFeatureGroupRepositoryAsync
    {
        private readonly DbSet<ProductFeatureGroup> _productFeatureGroup;

        public ProductFeatureGroupRepositoryAsync(ProductDbContext dbContext) : base(dbContext)
        {
            _productFeatureGroup = dbContext.Set<ProductFeatureGroup>();
        }

        public async Task<IEnumerable<ProductFeatureGroup>> GetAllWithEntityAsync()
        {
            var result = await _productFeatureGroup
                   .Include(p => p.ProductFeatures)
                   .AsNoTracking()
                   .ToListAsync();

            return result;
        }


    }
}
