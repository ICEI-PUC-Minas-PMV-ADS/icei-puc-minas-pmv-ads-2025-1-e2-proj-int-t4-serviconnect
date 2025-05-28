using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;
using ServiConnect.Repositorio;

namespace ServiConnect.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILoginRepositorio _loginRepositorio;
        public RegistroController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }
        
        
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrar(RegistroModel registroModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    LoginModel login = _loginRepositorio.BuscarPorEmail(registroModel.Email);

                    if (login == null)
                    {
                        if(login.SenhaValida(registroModel.Password))
                        {
                            return RedirectToAction("index", "Home");
                        }
                        TempData["MensagemErro"] = $"senha invalida";

                    }
                    TempData["MensagemErro"] = $"Email ou senha invalidos";
                }

                return View("index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"não foi possivel Logar, tente novamente, detalhe do erro : {erro.Message}";
                return RedirectToAction("index");
            }
        }
    }


}
