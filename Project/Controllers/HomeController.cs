using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public  IActionResult Index()
        {
            //return View();
            return View(_context.Cars.ToList());
        }
        

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Hello()

        {
            
            string myString = "Hello, this is a simple string response!";

            // Using ContentResult to return a string
            return Content(myString, "text/plain");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
