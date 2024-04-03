namespace Domain.Models
{
    public class ProductFeature
    {
        public short id { get; set; }
        public string? value { get; set; }
        public short productFeatureGroupId { get; set; }
        public ProductFeatureGroup productFeatureGroup { get; set; }
        public ICollection<Product> propertyType { get; set; }
        public ICollection<Product> furnitureCondition { get; set; }
        public ICollection<Product> numberOfRooms { get; set; }
        public ICollection<Product> floorLevel { get; set; }
        public ICollection<Product> buildingAge { get; set; }
    }
}