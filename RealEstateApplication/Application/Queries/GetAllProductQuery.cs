
using System.Collections.Generic;

namespace Application.Queries
{
    public class GetAllProductQuery  : BasePageQuery
    {
        public string search { get; set; }
        public int minPrice { get; set; }
        public int maxPrice { get; set; }
        public List<short> productBuildingAgeEnum { get; set; }
        public List<short> productFloorLevelEnum { get; set; }
        public List<short> productFurnitureConditionEnum { get; set; }
        public List<short> productNumberOfRoomsEnum { get; set; }
        public List<short> productPropertyTypeEnum { get; set; }
    }
}
