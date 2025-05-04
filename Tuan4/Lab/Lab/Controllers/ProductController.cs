using Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>() {
            new Product() { Id = 1, Name = "Áo sơ mi", Price = 100000 },
            new Product() { Id = 2, Name = "Quần âu", Price = 150000 },
            new Product() { Id = 3, Name = "Quần bò", Price = 200000 }
        };
        [Route("home-product")]
        public IActionResult Details()
        {
            return View(products);
        }
        [Route("create-product")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("save-product")]
        public IActionResult Save(Product product) {
            products.Add(product);
            return RedirectToAction("Details");
        }
    }
}
