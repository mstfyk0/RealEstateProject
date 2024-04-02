using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain.Common.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class ProductFeatureGroupManager : IProductFeatureGroupManager
    {
        private readonly IProductFeatureGroupRepositoryAsync _productFeatureGroupRepositoryAsync;
        protected IMapper _mapper;
        public ProductFeatureGroupManager(IProductFeatureGroupRepositoryAsync productFeatureGroupRepositoryAsync, IMapper mapper)
        {
            _productFeatureGroupRepositoryAsync = productFeatureGroupRepositoryAsync;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<ProductFeatureGroupDto>>> GetList()
        {
            var entityGroup = await _productFeatureGroupRepositoryAsync.GetAllWithEntityAsync();

            if (entityGroup is null)
                throw new ApiException(ProductFeatureException.ProductFeatureNotFound);

            var entityGroupDto = _mapper.Map<IEnumerable<ProductFeatureGroupDto>>(entityGroup);

            return new Response<IEnumerable<ProductFeatureGroupDto>>(entityGroupDto);
        }
    }
}
