using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace Components
{
    public class ProductFeatureMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductFeatureMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke(short id)
        {
            var productFeatureGroup = _manager.ProductFeatureGroupServices.GetOneProductFeatureGroup(id,false);
            var model = _manager.ProductFeatureServices.GetListProductFeature(productFeatureGroup.id, false);


            return View(model);
            //return View(model);

        }
    }
}