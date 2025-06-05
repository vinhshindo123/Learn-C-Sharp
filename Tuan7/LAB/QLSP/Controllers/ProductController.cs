using Microsoft.AspNetCore.Mvc;
using QLSP.Models;

namespace QLSP.Controllers
{
    public class ProductController : Controller
    {
        private readonly QLSPContext _context;

        public ProductController(QLSPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost()]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        [HttpGet()]
        public IActionResult Edit(int id)
        {
            Product selectedItem = _context.Products.FirstOrDefault(x => x.Id == id);
            return View(selectedItem);
        }
        [HttpPost()]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public IActionResult Delete(int id)
        {
            Product selectedItem = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(selectedItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
