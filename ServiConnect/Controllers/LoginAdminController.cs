using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;

namespace ServiConnect.Controllers
{
    public class LoginAdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Logar(LoginAdmin admin)
        {
            if (admin.Email == "admin@serviconnect.com" && admin.Password == "123456")
            {
                TempData["Mensagem"] = "Login de administrador realizado com sucesso!";
                return RedirectToAction("Dashboard"); // criar depois
            }
            else
            {
                ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");
                return View("Index");
            }
        }

       
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
