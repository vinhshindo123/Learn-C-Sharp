using Microsoft.AspNetCore.Mvc;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Add this namespace

namespace QLSV.Controllers
{
    public class StudentController : Controller
    {
        private readonly QlsvContext _context;
        public StudentController()
        {
            _context = new QlsvContext();
        }
        public IActionResult Index()
        {
            return View(_context.Students.Include(s => s.Class).ToList());
        }
    }
}