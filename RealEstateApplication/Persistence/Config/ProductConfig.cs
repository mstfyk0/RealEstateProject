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
            builder.Property(p => p.title).IsRequired();

            builder.Property(p => p.price).IsRequired();

            builder.HasData(
                new Product() { id = 1,buildingAgeId =1 , floorLevelId=1 , furnitureConditionId=1 , numberOfRoomsId=1 , propertyTypeId=1, totalSquareFootage=100 , ImageUrl = "/images/1.jpg", title = "MUHTE�EM DEN�Z MANZARALI V�LLA", price = 12345678,  },
                new Product() { id = 2,buildingAgeId =2 , floorLevelId=2 , furnitureConditionId=2 , numberOfRoomsId=2 , propertyTypeId=2, totalSquareFootage= 150,  ImageUrl = "/images/2.jpg", title = "SAH�LE YAKIN L�KS DA�RE", price = 9875643,  },
                new Product() { id = 3,buildingAgeId =3 , floorLevelId=1 , furnitureConditionId=3 , numberOfRoomsId=3 , propertyTypeId=3, totalSquareFootage= 80,  ImageUrl = "/images/3.jpg", title = "HUZURLU �EH�R EVDEN EVE TA�INMAYA HAZIR", price = 333225688,  },
                new Product() { id = 4,buildingAgeId = 1 , floorLevelId=2 , furnitureConditionId=4 , numberOfRoomsId=4 , propertyTypeId=4, totalSquareFootage= 90,  ImageUrl = "/images/4.jpg", title = "L�KS PENTHOUSE DA�RE", price = 9999999,  },
                new Product() { id = 5,buildingAgeId =2 , floorLevelId= 1, furnitureConditionId=5 , numberOfRoomsId=5 , propertyTypeId=5, totalSquareFootage=56 ,  ImageUrl = "/images/5.jpg", title = "�EH�R MERKEZ�NDE MODERN LOFT", price = 223344555,  },
                new Product() { id = 6,buildingAgeId =3 , floorLevelId=2 , furnitureConditionId=6 , numberOfRoomsId=6 , propertyTypeId=6, totalSquareFootage=89 ,  ImageUrl = "/images/6.jpg", title = "BAH�EL� M�STAK�L EV", price = 1240000,  },
                new Product() { id = 7,buildingAgeId =1 , floorLevelId=1 , furnitureConditionId=1 , numberOfRoomsId=7 , propertyTypeId=7, totalSquareFootage= 110,  ImageUrl = "/images/7.jpg", title = "DO�A �LE �� ��E HAVUZLU V�LLA", price = 234444,  },
                new Product() { id = 8,buildingAgeId =2 , floorLevelId=2 , furnitureConditionId=2 , numberOfRoomsId= 1, propertyTypeId=8, totalSquareFootage= 140,  ImageUrl = "/images/8.jpg", title = "SUN� G�LET MANZARALI DA�RE", price = 2300000, },
                new Product() { id = 9, buildingAgeId =3 , floorLevelId =1 , furnitureConditionId =3 , numberOfRoomsId =2 , propertyTypeId =9, totalSquareFootage =70 ,  ImageUrl = "/images/9.jpg", title = "YE��L B�R CENNETTE K�Y EV�", price = 540000, },
                new Product() { id = 10, buildingAgeId =1 , floorLevelId =2 , furnitureConditionId =4 , numberOfRoomsId = 3, propertyTypeId =10, totalSquareFootage =70 ,  ImageUrl = "/images/10.jpg", title = "ULA�IMI KOLAY MERKEZ� KONUM", price = 100000, }


            );
        }
    }
}