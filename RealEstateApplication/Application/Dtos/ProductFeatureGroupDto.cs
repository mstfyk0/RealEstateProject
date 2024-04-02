using System.Collections.Generic;

namespace Application.Dtos
{
    public record ProductFeatureGroupDto
    {
        public short id { get; init; }
        public string? value { get; init; }
        public ICollection<ProductFeatureDto> productFeature { get; init; }
    }
}
