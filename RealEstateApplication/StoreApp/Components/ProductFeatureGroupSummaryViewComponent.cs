using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Components
{
    public class ProductFeatureGroupSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductFeatureGroupSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager
            .ProductFeatureGroupServices
            .GetAllProductFeatureGroup(false)
            .Count()
            .ToString();

        }

    }
}