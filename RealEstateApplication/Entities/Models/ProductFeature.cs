namespace Domain.Models
{
    public class ProductFeature
    {
        public short id { get; set; }
        public string? value { get; set; }
        public short productFeatureGroupId { get; set; }
        public ICollection<Product> products { get; set;}
    }
}