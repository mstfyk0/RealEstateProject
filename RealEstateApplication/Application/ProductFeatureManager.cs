

using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain.Common.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class ProductFeatureManager : IProductFeatureManager
    {
        private readonly IProductFeatureRepositoryAsync _productFeatureRepositoryAsync;
        protected IMapper _mapper;
        public ProductFeatureManager(IProductFeatureRepositoryAsync productFeatureRepositoryAsync, IMapper mapper)
        {
            _productFeatureRepositoryAsync = productFeatureRepositoryAsync;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<ProductFeatureDto>>> GetList()
        {
            var entity = await _productFeatureRepositoryAsync.GetAllAsync();

            if (entity is null)
                throw new ApiException(ProductFeatureException.ProductFeatureNotFound);

            var entityDto = _mapper.Map<IEnumerable<ProductFeatureDto>>(entity);

            return new Response<IEnumerable<ProductFeatureDto>>(entityDto);
        }
    }
}
