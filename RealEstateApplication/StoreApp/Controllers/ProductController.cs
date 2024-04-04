
using Application.Interfaces;
using Domain.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Models;

namespace Controllers
{
    public class ProductController : Controller
    {

        // private readonly RepositoryContext _context;
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(ProductRequestParameters p )
        {
            var products= _manager.ProductService.GetAllProductsWithDetails(p);

            var pagination  = new Pagination() {
                CurrentPage=p.PageNumber,
                ItemsPerPage=p.PageSize,
                TotalItems= _manager.ProductService.GetAllProduct(false).Count()

            };
            return View(new ProductListViewModel () {
                Products=products,
                Pagination=pagination
            });

        }

        public IActionResult Get([FromRoute(Name ="id") ] int id)
        {

            var model= _manager.ProductService.GetOneProduct(id,false);

            ViewData["Title"]=model.title;
            return View(model);
        }
    }

}