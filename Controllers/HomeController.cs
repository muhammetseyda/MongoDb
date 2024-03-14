using Microsoft.AspNetCore.Mvc;
using MongoDb.Models;
using MongoDb.Services;
using System.Diagnostics;

namespace MongoDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CountryServices _countryServices;

        public HomeController(ILogger<HomeController> logger, CountryServices countryServices = null)
        {
            _logger = logger;
            _countryServices = countryServices;
        }

        public IActionResult Index()
        {
            var country = _countryServices.GetAllCountry();
            return View(country);
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