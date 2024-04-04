using Domain.Models;
namespace Persistence.Extensions
{
    public static class ProductRepositoryExtension
    {
        public static IQueryable<Product> FilterByProductId(this IQueryable<Product> products
         , List<short> buildingAgeId, List<short> floorLevelId, List<short> furnitureConditionId, List<short> numberOfRoomsId, List<short> propertyTypeId ,int? totalSquareFootage)
        {
            if (buildingAgeId is null 
                && floorLevelId is null
                && furnitureConditionId is null
                && numberOfRoomsId is null
                && propertyTypeId is null
                && totalSquareFootage is null
                )
            {
                return products;

            }
            else
            {
                return products.Where(prd => propertyTypeId.Contains(prd.propertyTypeId) 
                    || numberOfRoomsId.Contains(prd.numberOfRoomsId)
                    || furnitureConditionId.Contains(prd.furnitureConditionId)
                    || floorLevelId.Contains(prd.floorLevelId)
                    || buildingAgeId.Contains(prd.buildingAgeId)
                    || totalSquareFootage >= prd.totalSquareFootage
                    ) ;

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