using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            ViewData["Title"]="Welcome";
            return View ();
        }

        
    }
    
}