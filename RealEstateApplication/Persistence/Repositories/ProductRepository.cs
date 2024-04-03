
using Application.Interfaces;
using Domain.Models;
using Domain.RequestParameters;
using Persistence.Extensions;

namespace Persistence.Repositories
{
    public sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {


        }

        public IQueryable<Product> GetAllProducts(bool trackChange) => FindAll(trackChange);

        public IQueryable<Product> GetAllProductsWithDetails(ProductRequestParameters p)
        {
            // return p.CategoryId is null
            // ? _context
            //     .Products
            //     .Include(prd=> prd.Category)
            // :_context
            //     .Products
            //     .Include(prd=> prd.Category)
            //     .Where(prd => prd.CategoryId.Equals(p.CategoryId));
            return _context
                .Products
                .FilterByProductId(p.buildingAgeId,p.floorLevelId,p.furnitureConditionId,p.numberOfRoomsId,p.propertyTypeId)
                .FilteredBySearchTerm(p.SearchTerm)
                .FilteredByPrice(p.MinPrice, p.MaxPrice, p.IsValidPrice)
                .ToPaginate(p.PageNumber, p.PageSize)
                ;
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByCondition(p => p.id.Equals(id), trackChanges);

        }
    }


}