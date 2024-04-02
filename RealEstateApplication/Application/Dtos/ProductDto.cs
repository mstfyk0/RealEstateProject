namespace Application.Dtos
{
    public record ProductDto : BaseProductDto
    {
        public string productImageUrl { get; init; }
    }
}
