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
                new Product() { id = 1,buildingAgeId =1 , floorLevelId=4 , furnitureConditionId=6 , numberOfRoomsId=12 , propertyTypeId=19, totalSquareFootage=100 , ImageUrl = "/images/images1.jpg", title = "MUHTEÞEM DENÝZ MANZARALI VÝLLA", price = 12345678, description= "Harika manzaralý muhteþem bir gayrimenkul. Eþsiz doða ve deniz manzarasýna sahip olan bu mülk, lüks ve konforu bir araya getiriyor." ,ShowCase=true },
                new Product() { id = 2,buildingAgeId =2 , floorLevelId=5 , furnitureConditionId=7 , numberOfRoomsId=13 , propertyTypeId=20, totalSquareFootage= 150,  ImageUrl = "/images/images2.jpg", title = "SAHÝLE YAKIN LÜKS DAÝRE", price = 9875643, description= "Geniþ ve iyi tasarlanmýþ daire satýlýk. Ferah iç mekanlarý ve modern tasarýmý ile bu daire aileler için mükemmel bir seçenek.", ShowCase = true },
                new Product() { id = 3,buildingAgeId =3 , floorLevelId=4 , furnitureConditionId=8 , numberOfRoomsId=14 , propertyTypeId=21, totalSquareFootage= 80,  ImageUrl = "/images/images3.jpg", title = "HUZURLU ÞEHÝR EVDEN EVE TAÞINMAYA HAZIR", price = 333225688, description= "Huzurlu bir mahallede þirin bir ev. Sessiz ve sakin çevresiyle bu ev, huzurlu bir yaþam tarzýný arayanlar için ideal bir tercih.", ShowCase = true },
                new Product() { id = 4,buildingAgeId = 1 , floorLevelId=5 , furnitureConditionId=9 , numberOfRoomsId=15 , propertyTypeId=22, totalSquareFootage= 90,  ImageUrl = "/images/images4.jpg", title = "LÜKS PENTHOUSE DAÝRE", price = 9999999, description= "Zarif penthouse, üstün olanaklarla dolu. Modern ve lüks tasarýmýyla bu penthouse yaþam tarzýnýzý yükseltiyor.", ShowCase = true },
                new Product() { id = 5,buildingAgeId =2 , floorLevelId=4, furnitureConditionId=10 , numberOfRoomsId=16 , propertyTypeId=23, totalSquareFootage=56 ,  ImageUrl = "/images/images5.jpg", title = "ÞEHÝR MERKEZÝNDE MODERN LOFT", price = 223344555, description="Þehrin kalbinde modern bir loft. Merkezi konumu ve þýk tasarýmýyla bu loft, þehir hayatýnýn tadýný çýkarmak isteyenler için mükemmel bir seçenek.",
                    ShowCase = true
                },
                new Product() { id = 6,buildingAgeId =3 , floorLevelId=5 , furnitureConditionId=11 , numberOfRoomsId=17 , propertyTypeId=24, totalSquareFootage=89 ,  ImageUrl = "/images/images6.jpg", title = "BAHÇELÝ MÜSTAKÝL EV", price = 1240000, description= "Deniz kenarýnda keyifli bir tatil evi. Kumlu plajlara yakýn olan bu ev, yaz aylarýnda huzur dolu bir tatil imkaný sunuyor.", ShowCase = true },
                new Product() { id = 7,buildingAgeId =1 , floorLevelId=4 , furnitureConditionId=6 , numberOfRoomsId=18 , propertyTypeId=25, totalSquareFootage= 110,  ImageUrl = "/images/images7.jpg", title = "DOÐA ÝLE ÝÇ ÝÇE HAVUZLU VÝLLA", price = 234444, description= "Doðayla iç içe havuzlu bir villa. Muhteþem bahçesi ve özel havuzuyla bu villa, doðal güzelliklerle çevrili lüks bir yaþam sunuyor.", ShowCase = true },
                new Product() { id = 8,buildingAgeId =2 , floorLevelId=5 , furnitureConditionId=7 , numberOfRoomsId= 12, propertyTypeId=26, totalSquareFootage= 140,  ImageUrl = "/images/images8.jpg", title = "SUNÝ GÖLET MANZARALI DAÝRE", price = 2300000, description= "Gölet manzaralý modern bir daire. Doðal güzellikleri iç mekanlara taþýyan bu daire, huzurlu ve sakin bir yaþam sunuyor.", ShowCase = true },
                new Product() { id = 9, buildingAgeId =3 , floorLevelId =4 , furnitureConditionId =8 , numberOfRoomsId =13 , propertyTypeId =27, totalSquareFootage =70 ,  ImageUrl = "/images/images9.jpg", title = "YEÞÝL BÝR CENNETTE KÖY EVÝ", price = 540000, description= "Köy yaþamýnýn keyfini çýkarýn. Yeþillikler arasýnda yer alan bu köy evi, geleneksel ve huzurlu bir yaþam tarzý sunuyor." , ShowCase = true },
                new Product() { id = 10, buildingAgeId =1 , floorLevelId =5 , furnitureConditionId =9 , numberOfRoomsId = 14, propertyTypeId =28, totalSquareFootage =70 ,  ImageUrl = "/images/images10.jpg", title = "ULAÞIMI KOLAY MERKEZÝ KONUM", price = 100000, description= "Ulaþýmý kolay merkezi konum. Þehir merkezine yakýn olan bu ev, iþ ve sosyal aktivitelere ulaþýmý kolaylaþtýrýyor." , ShowCase = true  }


            );
        }
    }
}