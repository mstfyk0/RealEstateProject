namespace Domain.RequestParameters
{
    public class ProductRequestParameters : RequestParameters
    {
    
        public int MinPrice { get; set; } =0;
        public int MaxPrice { get; set; } =int.MaxValue;
        public bool IsValidPrice => MaxPrice> MinPrice;

        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public List<short> buildingAgeId { get; set; }
        public List<short> floorLevelId { get; set; }
        public List<short> furnitureConditionId { get; set; }
        public List<short> numberOfRoomsId { get; set; }
        public List<short> propertyTypeId { get; set; }
        public int? totalSquareFootage { get; set; }    

        public ProductRequestParameters() :this (1,6)
        {
            
        }

        public ProductRequestParameters(int pageNumber=1, int pageSize=6)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}