using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Components
{
    public class ProductFeatureGroupMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductFeatureGroupMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _manager.ProductFeatureGroupServices.GetAllProductFeatureGroup(false);



            return View(categories);

        }

    }
}