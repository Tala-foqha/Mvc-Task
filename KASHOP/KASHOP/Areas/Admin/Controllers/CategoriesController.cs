using KASHOP.Data;
using KASHOP.Models;
using Microsoft.AspNetCore.Mvc;

namespace KASHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();  
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                var category = context.Categories.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("create",request);
        }

        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);
            if (category != null)
            {
                return View(category);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(Category request,int id)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Update(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Edit",request);
        }

        public IActionResult remove(int id)
        {
            var category = context.Categories.Find(id);
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
 
}
}
