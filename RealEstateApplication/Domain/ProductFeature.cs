using System.Collections.Generic;

namespace Domain
{
    public class ProductFeature
    {

        public short id { get; set; }
        public string? value { get; set; } =string.Empty;
        public short productFeatureGroupId { get; set; }

        public ProductFeatureGroup productFeatureGroup { get; set; }
        public ICollection<Product> productPropertyType { get; set; }
        public ICollection<Product> productFurnitureCondition { get; set; }
        public ICollection<Product> productNumberOfRooms { get; set; }
        public ICollection<Product> productFloorLevel { get; set; }
        public ICollection<Product> productBuildingAge { get; set; }
    }
}