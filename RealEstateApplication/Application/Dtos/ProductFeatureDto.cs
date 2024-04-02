namespace Application.Dtos
{
    public record ProductFeatureDto
    {
        public short id { get; init; }
        public string? value { get; init; }
        public short productFeatureGroupId { get; init; }
    }
}
