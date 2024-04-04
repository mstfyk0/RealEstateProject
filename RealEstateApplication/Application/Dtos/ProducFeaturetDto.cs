
using Domain.Models;

namespace Application.Dtos
{
    public record ProducFeaturetDto
    {
        public short id { get; init; }
        public string? value { get; init; }
        public short productFeatureGroupId { get; init; }
        public IEnumerable<ProductFeatureGroup> ProductFeatureGroup { get; init; }
    }

}