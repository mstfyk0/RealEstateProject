namespace Domain.Models
{
    public class ProductFeatureGroup
    {
        public short id { get; set; }
        public string? value { get; set; }
        public ICollection<ProductFeatureGroup> productFeature { get; set; }
    }
}