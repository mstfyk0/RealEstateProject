
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Controllers
{
    public class ProductFeatureController : Controller
    {

        private IServiceManager _manager;

        public ProductFeatureController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var productFeatureGroup = _manager.ProductFeatureGroupServices.GetAllProductFeatureGroup(false);
            foreach (var productFeatureGroupId in productFeatureGroup)
            {

                var model = _manager.ProductFeatureServices.GetListProductFeature(productFeatureGroupId.id, false);
                return View(model);
            }

            return View();
        }
    }
}