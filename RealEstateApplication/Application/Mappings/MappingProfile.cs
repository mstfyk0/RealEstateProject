using Application.Dtos;
using AutoMapper;
using Domain;
using System.Collections.Generic;


namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductByIdDto>().ReverseMap();
            CreateMap<ProductFeatureGroupDto, ProductFeatureGroup>().ReverseMap();
            CreateMap<ProductFeatureDto, ProductFeature>().ReverseMap();
        }
    }
}
