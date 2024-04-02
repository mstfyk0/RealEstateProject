

using System;

namespace Application.Dtos
{
    public record BaseProductDto
    {
        public Guid id { get; init; }
        public short productPropertyTypeId { get; init; }
        public string productPropertyTypeValue { get; init; }

        public short productFurnitureConditionId { get; init; }
        public string productFurnitureConditionValue { get; init; }

        public short productNumberOfRoomsId { get; init; }
        public string productNumberOfRoomsValue { get; init; }

        public short productFloorLevelId { get; init; }
        public string productFloorLevelValue { get; init; }

        public short productBuildingAgeId { get; init; }
        public string productBuildingAgeValue { get; init; }

        public string productTitle { get; init; }
        public string productDescription { get; init; }
        public decimal productPrice { get; init; }
        public int productTotalSquareFootage { get; init; }
    }
}
