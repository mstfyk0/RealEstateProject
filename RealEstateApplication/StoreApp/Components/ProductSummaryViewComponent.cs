using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public string Invoke()
        {

            return _manager.ProductService.GetAllProduct(false).Count().ToString();
        }

    }
}