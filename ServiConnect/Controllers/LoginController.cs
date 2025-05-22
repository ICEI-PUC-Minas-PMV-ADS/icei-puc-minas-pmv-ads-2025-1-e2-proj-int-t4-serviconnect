using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ServiConnect.Models;
using ServiConnect.Repositorio;

namespace ServiConnect.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginRepositorio _LoginRepositorio;

        public LoginController(LoginRepositorio loginRepositorio)
        {
            _LoginRepositorio = loginRepositorio;
        }
        public IActionResult Index()
        {
            List<Login> login = _LoginRepositorio.BuscarTodos();
            
            return View();
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Login login)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    login = _LoginRepositorio.Adicionar(login);


                    TempData["Mensagem de sucesso"] = "contato cadastrado com sucesso!";
                }
                return View(login);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"não conseguimos cadastrar seu contato, tente novamente,detalhe de erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
