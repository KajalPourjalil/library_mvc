using Microsoft.AspNetCore.Mvc;

namespace library_mvc.AddControllersWithViews
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}