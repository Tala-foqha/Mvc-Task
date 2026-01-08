using CategoryMVCTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMVCTask.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var products = context.Categories;
            return View("Home", products
            );

        }
        public ViewResult Details(int Id)
        {
            var categories = context.Categories.Find(Id);
            return View("Details", categories);
        }

        public ViewResult Delete(int Id)
        {
            var categories = context.Categories.Find(Id);
            context.Categories.Remove(categories);
            context.SaveChanges();
            var category = context.Categories;
            return View("Home", category);
        }

        public ViewResult Create()
        {
            return View("Create"
            );
        }
        public ViewResult Store(Category request)
        {
            context.Categories.Add(request);
            context.SaveChanges();
            return View("Create");
        }
    }
}
