using Microsoft.AspNetCore.Mvc;

namespace Components
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}