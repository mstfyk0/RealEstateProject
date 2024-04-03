using Entities.Models;

namespace Entities.Dtos
{
    public record ProducFeatureGrouptDto
    {
        public short id { get; init; }
        public string? value { get; init; }
        public ICollection<ProductFeatureGroup> productFeatures { get; init; }

    }

}