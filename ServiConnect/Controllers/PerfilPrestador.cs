using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;

namespace WebApplication1.ServiConnect.Controllers
{
    public class PerfilPrestadorController : Controller
    {
        private readonly ILogger<PerfilPrestadorController> _logger;

        public PerfilPrestadorController(ILogger<PerfilPrestadorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
