using KASHOP.Data;
using KASHOP.Models;
using KASHOP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KASHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            //var products=context.Products.Join(context.Categories, p => p.CategoryId, c => c.Id, (p, c) => new Product
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    CategoryId = c.Id
            //}).ToList();
            var products = context.Products.Include(p => p.Category).ToList();
            var productVm = new List<ProductsViewModel>();
            foreach (var product in products)
            {
                var vm = new ProductsViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Image = $"/images/{product.Image}"
                };
                productVm.Add(vm);
            }
            return View(productVm);
        }

        public IActionResult Create()
        {
            //ViewData["categories"] = context.Categories.ToList();
            ViewBag.Categories = context.Categories.ToList();
            return View();
        }

        public IActionResult Store(Product request, IFormFile Image)
        {
            if (Image != null && Image.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString();
                fileName += Path.GetExtension(Image.FileName);

                var filePath = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    @"wwwroot\images",
                    fileName
                );

                using (var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyTo(stream);
                }

                request.Image = fileName; 
            }

            context.Products.Add(request);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
