
namespace Entities.Models;
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
    public ProductFeatureGroup propertyType { get; set; }
    public ProductFeatureGroup furnitureCondition { get; set; }
    public ProductFeatureGroup numberOfRooms { get; set; }
    public ProductFeatureGroup floorLevel { get; set; }
    public ProductFeatureGroup buildingAge { get; set; }
    public String? ImageUrl { get; set; } = String.Empty;

}
