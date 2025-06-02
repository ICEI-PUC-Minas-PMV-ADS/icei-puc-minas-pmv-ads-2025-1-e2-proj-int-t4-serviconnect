using Microsoft.AspNetCore.Mvc;
using ServiConnect.Models;
using ServiConnect.Repositorio;

namespace ServiConnect.Controllers
{
    public class PerfilUsuarioController : Controller
    {
        private readonly ILoginRepositorio _loginRepositorio;
        private LoginModel _userLogged;

        public PerfilUsuarioController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
            _userLogged = _loginRepositorio.BuscarTodos().FirstOrDefault();
            if (_userLogged == null)
            {
                throw new Exception("Nenhum usuário encontrado. Certifique-se de que há usuários cadastrados.");
            }

            Console.WriteLine($"User logged: {_userLogged?.Name}"); 
        }

        public IActionResult Index()
        {
            List<LoginModel> usuarios = _loginRepositorio.BuscarTodos();
            return View(_userLogged);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            
            if (_userLogged == null) return NotFound();

            return View(_userLogged);
        }

        [HttpPost]
        public IActionResult Editar(LoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userLogged.Name = model.Name;
                    _userLogged.Email = model.Email;
                    _userLogged.DataNascimento = model.DataNascimento;
                    _userLogged.InformacoesAdicionais = model.InformacoesAdicionais;

                    _loginRepositorio.Atualizar(_userLogged);

                    TempData["MensagemSucesso"] = "Dados atualizados com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível atualizar os dados, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            LoginModel usuario = _loginRepositorio.BuscarPorId(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _loginRepositorio.Apagar(id);

                if (apagado) 
                    TempData["MensagemSucesso"] = "Usuário apagado com sucesso"; 
                else 
                    TempData["MensagemErro"] = "Não foi possível apagar o usuário";
                
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível apagar o usuário, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}