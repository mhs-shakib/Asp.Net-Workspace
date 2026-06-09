using Demo_WebApplication.Codes;
using Demo_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_WebApplication.Controllers
{
    public class TestController : Controller
    {
       // private readonly IMembership _membership;
        //public TestController([FromKeyedServices("Setup 2")]IMembership membership)
        //{
        //    this._membership = membership;
        //}
        public IActionResult CreateAccount()
        {
            var model = new AccountModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateAccount(AccountModel model)
        {
           // _membership.CreateAccount (model.Username, model.Password);
            return View(model);
        }
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
