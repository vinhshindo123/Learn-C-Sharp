﻿using Microsoft.AspNetCore.Mvc;
using QLSV.Models;

namespace QLSV.Controllers
{
    public class ClassController : Controller
    {
        private readonly QlsvContext _context;
        public ClassController()
        {
            _context = new QlsvContext();
        }
        public IActionResult Index()
        {
            return View(_context.Classes.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Class item)
        {
            if (ModelState.IsValid)
            {
                _context.Classes.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Class selectedItem = _context.Classes.FirstOrDefault(x => x.ClassId == id);
            return View(selectedItem);
        }
        [HttpPost]
        public IActionResult Edit(Class item)
        {
            if (ModelState.IsValid)
            {
                _context.Classes.Update(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }
        public IActionResult Delete(int id)
        {
            Class selectedItem = _context.Classes.FirstOrDefault(x => x.ClassId == id);
            _context.Classes.Remove(selectedItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
