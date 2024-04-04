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
            builder.Property(p => p.description);
            builder.Property(p => p.totalSquareFootage);
            builder.Property(p => p.ImageUrl);

            builder.HasData(
                new Product() { id = 1,buildingAgeId =1 , floorLevelId=4 , furnitureConditionId=6 , numberOfRoomsId=12 , propertyTypeId=19, totalSquareFootage=100 , ImageUrl = "/images/images1.jpg", title = "MUHTE�EM DEN�Z MANZARALI V�LLA", price = 12345678, description= "Harika manzaral� muhte�em bir gayrimenkul. E�siz do�a ve deniz manzaras�na sahip olan bu m�lk, l�ks ve konforu bir araya getiriyor." ,ShowCase=true },
                new Product() { id = 2,buildingAgeId =2 , floorLevelId=5 , furnitureConditionId=7 , numberOfRoomsId=13 , propertyTypeId=20, totalSquareFootage= 150,  ImageUrl = "/images/images2.jpg", title = "SAH�LE YAKIN L�KS DA�RE", price = 9875643, description= "Geni� ve iyi tasarlanm�� daire sat�l�k. Ferah i� mekanlar� ve modern tasar�m� ile bu daire aileler i�in m�kemmel bir se�enek.", ShowCase = true },
                new Product() { id = 3,buildingAgeId =3 , floorLevelId=4 , furnitureConditionId=8 , numberOfRoomsId=14 , propertyTypeId=21, totalSquareFootage= 80,  ImageUrl = "/images/images3.jpg", title = "HUZURLU �EH�R EVDEN EVE TA�INMAYA HAZIR", price = 333225688, description= "Huzurlu bir mahallede �irin bir ev. Sessiz ve sakin �evresiyle bu ev, huzurlu bir ya�am tarz�n� arayanlar i�in ideal bir tercih.", ShowCase = true },
                new Product() { id = 4,buildingAgeId = 1 , floorLevelId=5 , furnitureConditionId=9 , numberOfRoomsId=15 , propertyTypeId=22, totalSquareFootage= 90,  ImageUrl = "/images/images4.jpg", title = "L�KS PENTHOUSE DA�RE", price = 9999999, description= "Zarif penthouse, �st�n olanaklarla dolu. Modern ve l�ks tasar�m�yla bu penthouse ya�am tarz�n�z� y�kseltiyor.", ShowCase = true },
                new Product() { id = 5,buildingAgeId =2 , floorLevelId=4, furnitureConditionId=10 , numberOfRoomsId=16 , propertyTypeId=23, totalSquareFootage=56 ,  ImageUrl = "/images/images5.jpg", title = "�EH�R MERKEZ�NDE MODERN LOFT", price = 223344555, description="�ehrin kalbinde modern bir loft. Merkezi konumu ve ��k tasar�m�yla bu loft, �ehir hayat�n�n tad�n� ��karmak isteyenler i�in m�kemmel bir se�enek.",
                    ShowCase = true
                },
                new Product() { id = 6,buildingAgeId =3 , floorLevelId=5 , furnitureConditionId=11 , numberOfRoomsId=17 , propertyTypeId=24, totalSquareFootage=89 ,  ImageUrl = "/images/images6.jpg", title = "BAH�EL� M�STAK�L EV", price = 1240000, description= "Deniz kenar�nda keyifli bir tatil evi. Kumlu plajlara yak�n olan bu ev, yaz aylar�nda huzur dolu bir tatil imkan� sunuyor.", ShowCase = true },
                new Product() { id = 7,buildingAgeId =1 , floorLevelId=4 , furnitureConditionId=6 , numberOfRoomsId=18 , propertyTypeId=25, totalSquareFootage= 110,  ImageUrl = "/images/images7.jpg", title = "DO�A �LE �� ��E HAVUZLU V�LLA", price = 234444, description= "Do�ayla i� i�e havuzlu bir villa. Muhte�em bah�esi ve �zel havuzuyla bu villa, do�al g�zelliklerle �evrili l�ks bir ya�am sunuyor.", ShowCase = true },
                new Product() { id = 8,buildingAgeId =2 , floorLevelId=5 , furnitureConditionId=7 , numberOfRoomsId= 12, propertyTypeId=26, totalSquareFootage= 140,  ImageUrl = "/images/images8.jpg", title = "SUN� G�LET MANZARALI DA�RE", price = 2300000, description= "G�let manzaral� modern bir daire. Do�al g�zellikleri i� mekanlara ta��yan bu daire, huzurlu ve sakin bir ya�am sunuyor.", ShowCase = true },
                new Product() { id = 9, buildingAgeId =3 , floorLevelId =4 , furnitureConditionId =8 , numberOfRoomsId =13 , propertyTypeId =27, totalSquareFootage =70 ,  ImageUrl = "/images/images9.jpg", title = "YE��L B�R CENNETTE K�Y EV�", price = 540000, description= "K�y ya�am�n�n keyfini ��kar�n. Ye�illikler aras�nda yer alan bu k�y evi, geleneksel ve huzurlu bir ya�am tarz� sunuyor." , ShowCase = true },
                new Product() { id = 10, buildingAgeId =1 , floorLevelId =5 , furnitureConditionId =9 , numberOfRoomsId = 14, propertyTypeId =28, totalSquareFootage =70 ,  ImageUrl = "/images/images10.jpg", title = "ULA�IMI KOLAY MERKEZ� KONUM", price = 100000, description= "Ula��m� kolay merkezi konum. �ehir merkezine yak�n olan bu ev, i� ve sosyal aktivitelere ula��m� kolayla�t�r�yor." , ShowCase = true  }


            );
        }
    }
}