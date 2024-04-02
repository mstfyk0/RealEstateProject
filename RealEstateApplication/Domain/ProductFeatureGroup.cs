

using System.Collections.Generic;

namespace Domain
{
    public class ProductFeatureGroup 
    {
        public short id { get; set; }
        public string? value { get; set; } = string.Empty;
        public ICollection<ProductFeature> ProductFeatures { get; set; }
    }
}
