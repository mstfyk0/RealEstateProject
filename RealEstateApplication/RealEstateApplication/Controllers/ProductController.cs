using Application.Interfaces;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateApplication.Controllers
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQuery getAllUsersQuery)
        {
            return Ok(await _productManager.GetList(getAllUsersQuery));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetProductByIdQuery getUserByIdQuery)
        {
            return Ok(await _productManager.GetById(getUserByIdQuery));
        }
    }
}
