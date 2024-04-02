using Domain.Common;

namespace Domain
{
    public class Product : BaseEntity
    {
        public short productPropertyTypeId { get; set; }
        public short productFurnitureConditionId { get; set; }
        public short productNumberOfRoomsId { get; set; }
        public short productFloorLevelId { get; set; }
        public short productBuildingAgeId { get; set; }
        public string? productName { get; set; }
        public string? productDescription { get; set; } = string.Empty; 
        public decimal productPrice { get; set; }
        public int productTotalSquareFootage { get; set; }
        public ProductFeature productPropertyType { get; set; }
        public ProductFeature  productFurnitureCondition { get; set; }
        public ProductFeature  productNumberOfRooms { get; set; }
        public ProductFeature  productFloorLevel { get; set; }
        public ProductFeature  productBuildingAge { get; set; }
        public string? ProductImageUrl { get; set; } = string.Empty;
    }
}

