using Demo_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_WebApplication.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestHome() { Name = "Mehedi Hasan Shakib", Email = "mhsshakib.ruet20@gmail.com" };
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(TestHome model)
        {
            var name = model.Name;
            var email = model.Email;
            return View(model);
        }
    }
}
