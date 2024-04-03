﻿using Application.Interfaces;
using Application.Queries;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;


namespace Persistence.Repositories
{
    public class ProductRepositoryAsync : GeneralRepositoryAsync<Product>, IProductRepositoryAsync
    {
        private readonly DbSet<Product> _product;

        public ProductRepositoryAsync(ProductDbContext dbContext) : base(dbContext)
        {
            _product = dbContext.Set<Product>();
        }

        public async Task<IEnumerable<Product>> GetBySearchAsync(GetAllProductQuery getAllProductQuery)
        {
            var result = _product
                   .Include(p => p.productPropertyType)
                   .Include(p => p.productFurnitureCondition)
                   .Include(p => p.productNumberOfRooms)
                   .Include(p => p.productFloorLevel)
                   .Include(p => p.productBuildingAge)
                   .Include(p => p.ProductImageUrl)
                   .Where(p =>
                     (
                         (
                           string.IsNullOrEmpty(getAllProductQuery.search) ||
                           (
                               !string.IsNullOrEmpty(getAllProductQuery.search) &&
                               ((p.productName ?? "") + (p.productDescription ?? "")).ToLower()
                               .Contains(getAllProductQuery.search.ToLower())
                           )
                         ) &&
                         (
                           (getAllProductQuery.minPrice == 0 && getAllProductQuery.maxPrice == 0) ||
                           (getAllProductQuery.maxPrice != 0 && getAllProductQuery.minPrice == 0 && p.productPrice <= getAllProductQuery.maxPrice) ||
                           (getAllProductQuery.minPrice != 0 && getAllProductQuery.maxPrice == 0 && getAllProductQuery.minPrice <= p.productPrice) ||
                           (getAllProductQuery.minPrice != 0 && getAllProductQuery.maxPrice != 0 && getAllProductQuery.minPrice <= p.productPrice && p.productPrice<= getAllProductQuery.maxPrice)
                         ) &&

                         (
                            (
                                getAllProductQuery.productBuildingAgeEnum == null ||

                                !getAllProductQuery.productBuildingAgeEnum.Any()
                            ) ||
                            (
                                getAllProductQuery.productBuildingAgeEnum != null &&
                                getAllProductQuery.productBuildingAgeEnum.Contains(p.productBuildingAgeId)
                            )

                         ) &&
                         (
                           (
                                getAllProductQuery.productFloorLevelEnum == null ||

                                !getAllProductQuery.productFloorLevelEnum.Any()
                           ) ||

                           (
                                getAllProductQuery.productFloorLevelEnum != null &&
                                getAllProductQuery.productBuildingAgeEnum.Contains(p.productBuildingAgeId)
                           )

                         ) &&

                         (
                           (
                                getAllProductQuery.productFurnitureConditionEnum == null ||

                                !getAllProductQuery.productFurnitureConditionEnum.Any()
                           ) ||

                           (
                                getAllProductQuery.productFurnitureConditionEnum != null &&
                                getAllProductQuery.productFurnitureConditionEnum.Contains(p.productFurnitureConditionId)
                           )

                         ) &&

                         (
                           (
                                getAllProductQuery.productNumberOfRoomsEnum == null ||

                                !getAllProductQuery.productNumberOfRoomsEnum.Any()
                           ) ||

                           (
                                getAllProductQuery.productNumberOfRoomsEnum != null &&


                                getAllProductQuery.productNumberOfRoomsEnum.Contains(p.productNumberOfRoomsId)
                           )

                         ) &&

                         (
                           (
                                getAllProductQuery.productPropertyTypeEnum == null ||

                                !getAllProductQuery.productPropertyTypeEnum.Any()
                           ) ||

                           (
                                getAllProductQuery.productPropertyTypeEnum != null &&
                                getAllProductQuery.productPropertyTypeEnum.Contains(p.productPropertyTypeId)
                           )

                         )
                     )

                   )
                   .Skip((getAllProductQuery.pageNumber - 1) * getAllProductQuery.pageSize)
                   .Take(getAllProductQuery.pageSize)
                   .AsNoTracking()
                   .ToList();

            return result;
        }

        public override async Task<Product> GetByIdAsync(Guid id)
        {
            var result = _product
                   .Include(p => p.productPropertyType)
                   .Include(p => p.productFurnitureCondition)
                   .Include(p => p.productNumberOfRooms)
                   .Include(p => p.productFloorLevel )
                   .Include(p => p.productBuildingAge )
                   .Include(p => p.ProductImageUrl)
                   .Where(p => p.Id == id)
                   .FirstOrDefault();
            return result;
        }

    }
}