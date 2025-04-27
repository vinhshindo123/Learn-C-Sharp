using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class TodoController : Controller
    {
        private readonly LoggerService _log;
        public TodoController(LoggerService log)
        {
            _log = log;
        }
        [Route("todo-home")]
        public IActionResult Index()
        {
            _log.LogViewAccess("Index");
            return View();
        }

        [Route("todo-add")]
        public IActionResult Add()
        {
            _log.LogViewAccess("Add");
            return View();
        }

        [Route("todo-edit")]
        public IActionResult Edit()
        {
            _log.LogViewAccess("Edit");
            return View();
        }

    }
}
