using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;

namespace ServiConnect.Controllers
{
    public class PaginaPesquisaController : Controller
    {
        private readonly ILogger<PaginaPesquisaController> _logger;

        public PaginaPesquisaController(ILogger<PaginaPesquisaController> logger)
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
