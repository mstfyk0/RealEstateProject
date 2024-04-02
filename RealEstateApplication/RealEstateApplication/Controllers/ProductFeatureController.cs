using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateApplication.Controllers
{
    [Route("api/product/feature")]
    public class ProductFeatureController : ControllerBase
    {
        private readonly IProductFeatureManager _entityManager;
        public ProductFeatureController(IProductFeatureManager entityManager)
        {
            _entityManager = entityManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _entityManager.GetList());
        }
    }
}
