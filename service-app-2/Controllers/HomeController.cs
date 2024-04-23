using Microsoft.AspNetCore.Mvc;
using service_app_2.Models;
using System.Diagnostics;

namespace service_app_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["ConfigValue"] = _configuration["Saudacao"];
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["ValorQualquer"] = _configuration["NovaChave"];
            return View();
        }
        public IActionResult DeployStaging()
        {

            return View();
        }
        
        private void TestMethod()
        {
            throw new Exception("This is a test exception");
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
