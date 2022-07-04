using Microsoft.AspNetCore.Mvc;
using ProjectSerilog.Abstract;
using ProjectSerilog.Models;
using System.Diagnostics;
using Microsoft.Extensions.Options;
using ProjectSerilog.Services.PositionOptions;
using ProjectSerilog.Services.SerilogOption;

namespace ProjectSerilog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISeriLogger _seriLogger;

        public HomeController( ISeriLogger seriLogger )
        {
            _seriLogger = seriLogger;
        }

        public IActionResult Index()
        {
            _seriLogger.Information("Index");
        
            return View();
        }

        public IActionResult Privacy()
        {
            _seriLogger.Information("Privacy Sayfası");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _seriLogger.Error("Hata Sayfası");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
