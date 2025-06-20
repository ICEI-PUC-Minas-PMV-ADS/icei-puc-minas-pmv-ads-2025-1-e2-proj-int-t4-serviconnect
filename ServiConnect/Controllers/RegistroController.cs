using Microsoft.AspNetCore.Mvc;
using ServiConnect.Helper;
using ServiConnect.Models;
using ServiConnect.Repositorio;

namespace ServiConnect.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILoginRepositorio _loginRepositorio;
        private readonly IEmail _email;
        
       public RegistroController(ILoginRepositorio loginRepositorio,
                                 IEmail email)
                                 
        {
            _loginRepositorio = loginRepositorio;
            _email = email;
            
        }


        

        public IActionResult RedefinirSenha()
        {
            return View();
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

                    if (login != null)
                    {
                        if (login.SenhaValida(registroModel.Password))
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

        public IActionResult Criar(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    login = _loginRepositorio.Adicionar(login);

                    TempData["MensagemSucesso"] = "Login cadastrado com sucesso";
                    return RedirectToAction("Index, Home ");
                }
                return View("index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos cadastrar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }




        [HttpPost]
        public IActionResult EnviarLinkParaRedefinirSenha(RedefinirSenhaModel RedefinirSenha)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LoginModel login = _loginRepositorio.BuscarPorEmailEName(RedefinirSenha.Name, RedefinirSenha.Email);

                    if (login != null)
                    {
                        string novoPassword = login.GerarNovoPassword();
                        string mensagem = $"Sua nova senha é:{novoPassword}";
                       
                        bool emailEnviado = _email.Enviar(login.Email, "Sistema de Contatos - Nova Senha", mensagem);
                        
                        if (emailEnviado)
                        {
                            _loginRepositorio.Atualizar(login);
                            TempData["MensagemSucesso"] = $"Enviamos para seu e-mail cadastrado uma nova senha";
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"Não conseguimos Enviar o email,Por favor,verifique os dados e tente novamente";
                        }    


                            return RedirectToAction("Index", "Registro");
                    }
                    TempData["MensagemErro"] = $"Não conseguimos redefinir sua senha,Por favor,verifique os dados e tente novamente";
                }
                return View("index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos cadastrar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        

    }
}
