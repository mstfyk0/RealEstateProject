using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.title);
            builder.Property(p => p.price);
            builder.Property(p => p.buildingAgeId);
            builder.Property(p => p.furnitureConditionId);
            builder.Property(p => p.numberOfRoomsId);
            builder.Property(p => p.propertyTypeId);
            builder.Property(p => p.totalSquareFootage);
            builder.Property(p => p.ImageUrl);

            builder.HasData(
                new Product() { id = 1,buildingAgeId =1 , floorLevelId=4 , furnitureConditionId=6 , numberOfRoomsId=12 , propertyTypeId=19, totalSquareFootage=100 , ImageUrl = "/images/1.jpg", title = "MUHTEÞEM DENÝZ MANZARALI VÝLLA", price = 12345678,  },
                new Product() { id = 2,buildingAgeId =2 , floorLevelId=5 , furnitureConditionId=7 , numberOfRoomsId=13 , propertyTypeId=20, totalSquareFootage= 150,  ImageUrl = "/images/2.jpg", title = "SAHÝLE YAKIN LÜKS DAÝRE", price = 9875643,  },
                new Product() { id = 3,buildingAgeId =3 , floorLevelId=4 , furnitureConditionId=8 , numberOfRoomsId=14 , propertyTypeId=21, totalSquareFootage= 80,  ImageUrl = "/images/3.jpg", title = "HUZURLU ÞEHÝR EVDEN EVE TAÞINMAYA HAZIR", price = 333225688,  },
                new Product() { id = 4,buildingAgeId = 1 , floorLevelId=5 , furnitureConditionId=9 , numberOfRoomsId=15 , propertyTypeId=22, totalSquareFootage= 90,  ImageUrl = "/images/4.jpg", title = "LÜKS PENTHOUSE DAÝRE", price = 9999999,  },
                new Product() { id = 5,buildingAgeId =2 , floorLevelId=4, furnitureConditionId=10 , numberOfRoomsId=16 , propertyTypeId=23, totalSquareFootage=56 ,  ImageUrl = "/images/5.jpg", title = "ÞEHÝR MERKEZÝNDE MODERN LOFT", price = 223344555,  },
                new Product() { id = 6,buildingAgeId =3 , floorLevelId=5 , furnitureConditionId=11 , numberOfRoomsId=17 , propertyTypeId=24, totalSquareFootage=89 ,  ImageUrl = "/images/6.jpg", title = "BAHÇELÝ MÜSTAKÝL EV", price = 1240000,  },
                new Product() { id = 7,buildingAgeId =1 , floorLevelId=4 , furnitureConditionId=6 , numberOfRoomsId=18 , propertyTypeId=25, totalSquareFootage= 110,  ImageUrl = "/images/7.jpg", title = "DOÐA ÝLE ÝÇ ÝÇE HAVUZLU VÝLLA", price = 234444,  },
                new Product() { id = 8,buildingAgeId =2 , floorLevelId=5 , furnitureConditionId=7 , numberOfRoomsId= 12, propertyTypeId=26, totalSquareFootage= 140,  ImageUrl = "/images/8.jpg", title = "SUNÝ GÖLET MANZARALI DAÝRE", price = 2300000, },
                new Product() { id = 9, buildingAgeId =3 , floorLevelId =4 , furnitureConditionId =8 , numberOfRoomsId =13 , propertyTypeId =27, totalSquareFootage =70 ,  ImageUrl = "/images/9.jpg", title = "YEÞÝL BÝR CENNETTE KÖY EVÝ", price = 540000, },
                new Product() { id = 10, buildingAgeId =1 , floorLevelId =5 , furnitureConditionId =9 , numberOfRoomsId = 14, propertyTypeId =28, totalSquareFootage =70 ,  ImageUrl = "/images/10.jpg", title = "ULAÞIMI KOLAY MERKEZÝ KONUM", price = 100000, }


            );
        }
    }
}