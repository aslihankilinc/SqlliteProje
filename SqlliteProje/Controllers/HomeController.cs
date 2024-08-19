using Microsoft.AspNetCore.Mvc;
using Sqllite.Business;
using Sqllite.Data.Table;
using SqlliteProje.Models;
using System.Diagnostics;

namespace SqlliteProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        SqlliteService service = new();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Category> list = new();
            if (service.SetCategory().Result)
            {
                list =   service.GetCategory().Result;
            }
            return View(model: list);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
