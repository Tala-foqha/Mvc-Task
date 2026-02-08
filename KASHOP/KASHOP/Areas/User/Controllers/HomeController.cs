using KASHOP.Data;
using Microsoft.AspNetCore.Mvc;

namespace KASHOP.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Product()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
