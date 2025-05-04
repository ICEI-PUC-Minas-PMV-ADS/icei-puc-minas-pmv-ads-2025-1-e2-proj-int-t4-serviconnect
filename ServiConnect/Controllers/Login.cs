using Microsoft.AspNetCore.Mvc;

namespace ServiConnect.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
