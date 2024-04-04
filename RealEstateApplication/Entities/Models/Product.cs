
namespace Domain.Models
{
    public class Product : AuditableBaseEntity
    {
        public short propertyTypeId { get; set; }
        public short furnitureConditionId { get; set; }
        public short numberOfRoomsId { get; set; }
        public short floorLevelId { get; set; }
        public short buildingAgeId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int totalSquareFootage { get; set; }
        public String? ImageUrl { get; set; } = String.Empty;
        public bool ShowCase { get; set; }
        public ProductFeature? productFeature { get; set; } 
    }
}
