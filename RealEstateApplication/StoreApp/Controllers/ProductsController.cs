using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Presentation.Controllers
{
    
[Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ProductsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_manager.ProductService.GetAllProduct(false));
        }
    }

}