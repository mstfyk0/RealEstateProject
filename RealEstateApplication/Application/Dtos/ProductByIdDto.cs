using System.Collections.Generic;

namespace Application.Dtos
{
    public record ProductByIdDto : BaseProductDto
    {
        public List<string> productImageUrls { get; init; }


    }
}
