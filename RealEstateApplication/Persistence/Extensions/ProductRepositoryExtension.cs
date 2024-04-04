using Domain.Models;
using Microsoft.IdentityModel.Tokens;
namespace Persistence.Extensions
{
    public static class ProductRepositoryExtension
    {
        public static IQueryable<Product> FilterByProductId(this IQueryable<Product> products
         , List<short> featureId )
        {
            if (featureId.IsNullOrEmpty())
            {
                return products;

            }
            else
            {
                return products.Where(prd => featureId.Contains(prd.propertyTypeId) 
                    || featureId.Contains(prd.numberOfRoomsId)
                    || featureId.Contains(prd.furnitureConditionId)
                    || featureId.Contains(prd.floorLevelId)
                    || featureId.Contains(prd.buildingAgeId)
                    );

            }
        }
        public static IQueryable<Product> FilteredBySearchTerm(this IQueryable<Product> products

        , String? searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return products;
            }
            else
            {
                return products
                .Where(prd => prd.title.ToLower()
                .Contains(searchTerm.ToLower()));
            }
        }
        public static IQueryable<Product> FilteredByPrice(this IQueryable<Product> products,
        int minPrice, int maxPrice, bool isValidPrice)
        {
            if (isValidPrice)
                return products.Where(prd => prd.price >=minPrice && prd.price <= maxPrice);
            else
                return products;

        }

         public static IQueryable<Product> ToPaginate(this IQueryable<Product> products, int pageNumber
        , int pageSize)
        {

            return products
            .Skip(((pageNumber - 1) * pageSize))
            .Take(pageSize);


        }
    }
}