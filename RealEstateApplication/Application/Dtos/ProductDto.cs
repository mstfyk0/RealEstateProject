using Entities.Models;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public short propertyTypeId { get; init; }
        public short furnitureConditionId { get; init; }
        public short numberOfRoomsId { get; init; }
        public short floorLevelId { get; init; }
        public short buildingAgeId { get; init; }
        public string title { get; init; }
        public string description { get; init; }
        public decimal price { get; init; }
        public int totalSquareFootage { get; init; }
        public ProductFeatureGroup propertyType { get; init; }
        public ProductFeatureGroup furnitureCondition { get; init; }
        public ProductFeatureGroup numberOfRooms { get; init; }
        public ProductFeatureGroup floorLevel { get; init; }
        public ProductFeatureGroup buildingAge { get; init; }
        public String? ImageUrl { get; set; } =String.Empty;
    }

}