
using Demo_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Demo_WebApplication.Codes;
using Serilog;
using Demo.Application.Contracts;

namespace Demo_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IMembership _membership;
        private readonly ILogger<HomeController> _logger;
        public HomeController (  ILogger<HomeController>logger)
        {
            //_membership = membership;
            this._logger = logger;
        }
        public IActionResult Index()
        {
    
            Log.Debug("I am in homepage");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreateAccount()
        {
            var model = new AccountModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateAccount(AccountModel model)
        {
            
            //_membership.CreateAccount(model.Username, model.Password);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
