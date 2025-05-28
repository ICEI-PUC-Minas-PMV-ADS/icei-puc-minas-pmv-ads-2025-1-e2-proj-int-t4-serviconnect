using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;
using ServiConnect.Repositorio;

namespace ServiConnect.Controllers
{
    public class LoginNormalController : Controller
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public LoginNormalController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }
        public IActionResult Index()
        {
            List<LoginModel> login = _loginRepositorio.BuscarTodos();
            
            return View(login);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            LoginModel login = _loginRepositorio.BuscarPorId(id);
            return View(login);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _loginRepositorio.Apagar(id);

                if (apagado) TempData["MensagemSucesso"] = "Login apagado com sucesso"; else TempData["MensagemErro"] = "não foi possivel apagar o Login";
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"não foi possivel apagar o Login, tente novamente, detalhe do erro : {erro.Message}";
                return RedirectToAction("index");
            }
        }
        [HttpPost]
        public IActionResult Criar(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    login = _loginRepositorio.Adicionar(login);

                    TempData["MensagemSucesso"] = "Login cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(login);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos cadastrar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
