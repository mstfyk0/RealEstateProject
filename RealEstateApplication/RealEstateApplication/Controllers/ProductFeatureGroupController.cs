using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateApplication.Controllers
{
    [Route("api/product/featureGrup")]
    public class ProductFeatureGroupController : ControllerBase
    {
        private readonly IProductFeatureGroupManager _entityGroupManager;
        public ProductFeatureGroupController(IProductFeatureGroupManager entityGroupManager)
        {
            _entityGroupManager = entityGroupManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _entityGroupManager.GetList());
        }
    }
}
