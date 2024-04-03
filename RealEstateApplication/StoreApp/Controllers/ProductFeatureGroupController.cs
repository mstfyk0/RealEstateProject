
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Controllers
{
    public class ProductFeatureGroupController : Controller
    {
        
        private IServiceManager _manager;

        public ProductFeatureGroupController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {

            var model =  _manager.ProductFeatureGroupServices.GetAllProductFeatureGroup(false);          
            return View(model);

        }
    }
}