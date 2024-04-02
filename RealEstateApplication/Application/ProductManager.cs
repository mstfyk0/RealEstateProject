using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces;
using Application.Queries;
using AutoMapper;
using Domain.Common.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepositoryAsync _productRepositoryAsync;
        protected IMapper _mapper;

        public ProductManager(IProductRepositoryAsync productRepositoryAsync, IMapper mapper)
        {
            _productRepositoryAsync = productRepositoryAsync;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<ProductDto>>> GetList(GetAllProductQuery getAllProductQuery)
        {
            var product = await _productRepositoryAsync.GetBySearchAsync(getAllProductQuery);
            if (product is null)
                throw new ApiException(ProductException.ProductNotFound);

            var productDto = _mapper.Map<IEnumerable<ProductDto>>(product);
            return new PagedResponse<IEnumerable<ProductDto>>(productDto, getAllProductQuery);
        }

        public async Task<Response<ProductByIdDto>> GetById(GetProductByIdQuery getProductById)
        {
            var product = await _productRepositoryAsync.GetByIdAsync(getProductById.id);
            if (product is null)
                throw new ApiException(ProductException.ProductNotFound);

            var productDto = _mapper.Map<ProductByIdDto>(product);
            return new Response<ProductByIdDto>(productDto);
        }
    }
}
