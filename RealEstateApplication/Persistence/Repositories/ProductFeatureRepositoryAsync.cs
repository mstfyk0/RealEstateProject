using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;


namespace Persistence.Repositories
{

    public class ProductFeatureRepositoryAsync : GeneralRepositoryAsync<ProductFeature>, IProductFeatureRepositoryAsync
    {
        private readonly DbSet<ProductFeature> _entity;

        public ProductFeatureRepositoryAsync(ProductDbContext dbContext) : base(dbContext)
        {
            _entity = dbContext.Set<ProductFeature>();
        }
    }
}
