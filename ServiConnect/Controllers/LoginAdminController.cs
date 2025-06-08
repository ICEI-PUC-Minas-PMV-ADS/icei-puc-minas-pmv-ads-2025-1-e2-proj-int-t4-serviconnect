using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;
using System.Linq;

namespace ServiConnect.Controllers
{
    public class LoginAdminController : Controller
    {
        private readonly AppDbContext _context;

        // Construtor com injeção de dependência
        public LoginAdminController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /LoginAdmin
        public IActionResult Index()
        {
            return View();
        }

        // POST: /LoginAdmin/Logar
        [HttpPost]
        public IActionResult Logar(LoginAdmin admin)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", admin);
            }

            // Busca no banco de dados
            var adminExistente = _context.LoginAdmins
                .FirstOrDefault(a => a.Email == admin.Email && a.Password == admin.Password);

            if (adminExistente != null)
            {
                TempData["Mensagem"] = "Login de administrador realizado com sucesso!";
                return RedirectToAction("Index", "PrestadoresControler"); // vai para página do Fe
            }
            else
            {
                ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");
                return View("Index");
            }
        }

        // Página após login, se quiser
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
