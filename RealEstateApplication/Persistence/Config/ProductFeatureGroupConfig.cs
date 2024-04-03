using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config
{
    public class ProductFeatureGroupConfig : IEntityTypeConfiguration<ProductFeatureGroup>
    {
        public void Configure(EntityTypeBuilder<ProductFeatureGroup> builder)
        {
            builder.HasKey(c=>c.id);
            builder.Property(c=>c.value).IsRequired();
            builder.HasData(
                new ProductFeatureGroup() { id = 1, value = "Emlak Tipi" },
                new ProductFeatureGroup() { id = 2, value = "E�ya Durumu" },
                new ProductFeatureGroup() { id = 3, value = "Oda Say�s�" },
                new ProductFeatureGroup() { id = 4, value = "Bulundu�u Kat" },
                new ProductFeatureGroup() { id = 5, value = "Bina Ya��" }
            );
        }
    }
}