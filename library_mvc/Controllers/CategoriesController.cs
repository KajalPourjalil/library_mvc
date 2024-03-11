using Microsoft.AspNetCore.Mvc;
using library_mvc.Models;

namespace library_mvc.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        
    }
}