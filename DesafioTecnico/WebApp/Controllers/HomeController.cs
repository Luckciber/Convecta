using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using Services.Interfaces;
using Services.Implementations;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICountriesService _countriesService;
        public HomeController(
            ILogger<HomeController> logger,
            ICountriesService countriesService
            )
        {
            _logger = logger;
            _countriesService = countriesService;
        }

        public IActionResult Index()
        {
            _countriesService.GetCountries();
            return View();
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
