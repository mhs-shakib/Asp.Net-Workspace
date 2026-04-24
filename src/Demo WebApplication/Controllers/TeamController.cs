using Microsoft.AspNetCore.Mvc;
using Demo_WebApplication.Models;

namespace Demo_WebApplication.Controllers
 
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            TeamListModel model = new TeamListModel();
            model.Id = 101;
            model.Name = "MD. Mehedi Hasan Sarker Shakib";
            model.Email = "mhsshakib.ruet20@gmail.com";
            return View(model);
        }
    }
} 

