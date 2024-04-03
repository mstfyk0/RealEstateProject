using Domain;
using Domain.Common.Enums;
using Microsoft.EntityFrameworkCore;
using Persistence.Generate;

namespace Persistence.Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductFeatureGroup> ProductFeatureGroups { get; set; }
        public DbSet<Product> Products { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductFeatureGroup>()
                .HasData(
                    new ProductFeatureGroup()
                    {
                        id = (short)ProductFeatureGroupEnum.PropertyType,
                        value = "Emlak Tipi"
                    },
                    new ProductFeatureGroup()
                    {
                        id = (short)ProductFeatureGroupEnum.FurnitureCondition,
                        value = "Eşya Durumu"
                    },
                    new ProductFeatureGroup()
                    {
                        id = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "Oda Sayısı"
                    },
                    new ProductFeatureGroup()
                    {
                        id = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "Bulunduğu Kat"
                    },
                    new ProductFeatureGroup()
                    {
                        id = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "Bina Yaşı"
                    }
            );

            modelBuilder.Entity<ProductFeature>()
                .HasData(
                    new ProductFeature()
                    {
                        id = (short)PropertyTypeEnum.Sale,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.PropertyType,
                        value = "Satılık"
                    },
                    new ProductFeature()
                    {
                        id = (short)PropertyTypeEnum.Rent,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.PropertyType,
                        value = "Kiralık"
                    },
                    new ProductFeature()
                    {
                        id = (short)PropertyTypeEnum.Daily,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.PropertyType,
                        value = "Günlük"
                    },
                    new ProductFeature()
                    {
                        id = (short)FurnitureConditionEnum.Furnished,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FurnitureCondition,
                        value = "Eşyalı"
                    },
                    new ProductFeature()
                    {
                        id = (short)FurnitureConditionEnum.Unfurnished,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FurnitureCondition,
                        value = "Eşyasız"
                    },
                    new ProductFeature()
                    {
                        id = (short)NumberOfRoomsEnum.OnePlusZero,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "1 + 0"
                    },
                    new ProductFeature()
                    {
                        id = (short)NumberOfRoomsEnum.OnePlusOne,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "1 + 1"
                    },
                    new ProductFeature()
                    {
                        id = (short)NumberOfRoomsEnum.TwoPlusOne,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "2 + 1"
                    },
                    new ProductFeature()
                    {
                        id = (short)NumberOfRoomsEnum.ThreePlusOne,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "3 + 1"
                    },
                    new ProductFeature()
                    {
                        id = (short)NumberOfRoomsEnum.ThreePlusTwo,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "3 + 2"
                    },
                    new ProductFeature()
                    {
                        id = (short)NumberOfRoomsEnum.FourPlusTwo,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.NumberOfRooms,
                        value = "4 + 2"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.GardenFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "Bahçe Katı"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.EntranceFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "Giriş Katı"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.FirstFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "1. Kat"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.SecondFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "2. Kat"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.ThirdFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "3. Kat"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.FourthFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "4. Kat"
                    },
                    new ProductFeature()
                    {
                        id = (short)FloorLevelEnum.FifthFloor,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.FloorLevel,
                        value = "5. Kat"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeZero,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "0"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeOne,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "1"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeTwo,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "2"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeThree,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "3"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeFour,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "4"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeFive,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "5"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeFromFiveToTen,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "5 - 10"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeFromTenToFifteen,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "10 - 15"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgeFromFifteenToTwenty,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = "15 - 20"
                    },
                    new ProductFeature()
                    {
                        id = (short)BuildingAgeEnum.BuildingAgePlusTwenty,
                        productFeatureGroupId = (short)ProductFeatureGroupEnum.BuildingAge,
                        value = " > 20"
                    }
              );

            modelBuilder.Entity<Product>()
                   .HasData(
                      RandomGenerate.GenerateRandomProductList()
                 );

            modelBuilder.Entity<ProductFeature>()
               .HasOne(c => c.productFeatureGroup)
               .WithMany(d => d.ProductFeatures);

            modelBuilder.Entity<Product>()
               .HasOne(c => c.productPropertyType)
               .WithMany(d => d.productPropertyType)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
               .HasOne(c => c.productFurnitureCondition )
               .WithMany(d => d.productFurnitureCondition)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
              .HasOne(c => c.productNumberOfRooms )
              .WithMany(d => d.productNumberOfRooms )
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
              .HasOne(c => c.productFloorLevel )
              .WithMany(d => d. productFloorLevel)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
              .HasOne(c => c.productBuildingAge)
              .WithMany(d => d.productBuildingAge )
              .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
