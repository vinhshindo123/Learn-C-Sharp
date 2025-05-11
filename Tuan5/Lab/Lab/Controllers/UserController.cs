using Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="2",username="bbb",password="1",phone="111",email="111"},
             new User() {id="3",username="ccc",password="1",phone="111",email="111"},
             new User() {id="4",username="ccc",password="1",phone="111",email="111"},
             new User() {id="5",username="ddd",password="1",phone="111",email="111"},
        };

        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    users.Add(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex) 
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }
        [HttpGet("User/Edit/{id}")]
        public IActionResult Edit(string id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User upUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var exUser = users.FirstOrDefault(u => u.id == upUser.id);
                    if (exUser == null)
                    {
                        return NotFound();
                    }

                    exUser.username = upUser.username;
                    exUser.password = upUser.password;
                    exUser.phone = upUser.phone;
                    exUser.email = upUser.email;

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(upUser);
        }
    }
}
