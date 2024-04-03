using Entities.Models;

namespace Entities.Dtos
{
    public record ProducFeaturetDto
    {
        public short id { get; init; }
        public string? value { get; init; }
        public short productFeatureGroupId { get; init; }
    }

}