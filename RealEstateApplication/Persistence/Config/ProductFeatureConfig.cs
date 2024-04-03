using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config
{
    public class ProductFeatureConfig : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(c => c.id);
            builder.Property(c => c.value).IsRequired();
            builder.HasData(
                new ProductFeature() { id = 1, value = "Satılık" , productFeatureGroupId=1 },
                new ProductFeature() { id = 2, value = "Kiralık", productFeatureGroupId=1 },
                new ProductFeature() { id = 3, value = "Günlük", productFeatureGroupId=1 },

                new ProductFeature() { id = 1, value = "Eşyalı" , productFeatureGroupId=2 },
                new ProductFeature() { id = 2, value = "Eşyasız", productFeatureGroupId=2 },

                new ProductFeature() { id = 1, value = "1 + 0", productFeatureGroupId=3 },
                new ProductFeature() { id = 2, value = "1 + 1", productFeatureGroupId=3 },
                new ProductFeature() { id = 3, value = "2 + 1", productFeatureGroupId = 3 },
                new ProductFeature() { id = 4, value = "3 + 1", productFeatureGroupId=3 },
                new ProductFeature() { id = 5, value = "3 + 2", productFeatureGroupId = 3 },
                new ProductFeature() { id = 6, value = "4 + 2", productFeatureGroupId = 3 },

                new ProductFeature() { id = 1, value = "Bahçe Katı" , productFeatureGroupId = 4 },
                new ProductFeature() { id = 2, value = "Giriş Katı", productFeatureGroupId = 4 },
                new ProductFeature() { id = 3, value = "1. Kat", productFeatureGroupId = 4 },
                new ProductFeature() { id = 4, value = "2. Kat", productFeatureGroupId = 4 },
                new ProductFeature() { id = 5, value = "3. Kat", productFeatureGroupId = 4 },
                new ProductFeature() { id = 6, value = "4 Kat", productFeatureGroupId = 4 },
                new ProductFeature() { id = 7, value = "5. Kat", productFeatureGroupId = 4 },

                new ProductFeature() { id = 1, value = "0", productFeatureGroupId = 5 },
                new ProductFeature() { id = 2, value = "1", productFeatureGroupId = 5 },
                new ProductFeature() { id = 3, value = "2", productFeatureGroupId = 5 },
                new ProductFeature() { id = 4, value = "3", productFeatureGroupId = 5 },
                new ProductFeature() { id = 5, value = "4", productFeatureGroupId = 5 },
                new ProductFeature() { id = 6, value = "5", productFeatureGroupId = 5 },
                new ProductFeature() { id = 7, value = "5-10", productFeatureGroupId = 5 },
                new ProductFeature() { id = 8, value = "10-15", productFeatureGroupId = 5 },
                new ProductFeature() { id = 9, value = "15-20", productFeatureGroupId = 5 },
                new ProductFeature() { id = 10, value = "20>", productFeatureGroupId = 5 }
            );
        }
    }
}