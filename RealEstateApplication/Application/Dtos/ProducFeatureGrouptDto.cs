

using Domain.Models;

namespace Application.Dtos
{
    public record ProducFeatureGrouptDto
    {
        public short id { get; init; }
        public string? value { get; init; }
        public ICollection<ProductFeatureGroup> productFeaturesGroup { get; init; }

    }

}