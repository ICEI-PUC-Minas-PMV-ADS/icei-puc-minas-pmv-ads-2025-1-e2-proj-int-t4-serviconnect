using ServiConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;



namespace ServiConnect.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly AppDbContext _appDbContext;
        
        public LoginRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
          public Login BuscarPorId(int id)
        {
            return _appDbContext.Login.FirstOrDefault(x => x.Id == id);
        }
        public List<Login> BuscarTodos()
        {
            return _appDbContext.Login.ToList();
        }
        public Login Adicionar(Login login)
        {
            _appDbContext.Login.Add(login);
            _appDbContext.SaveChanges();
            return login;
        }
        public Login Atualizar(Login login)
        {
            Login appDbContext = BuscarPorId(login.Id);
            if (appDbContext == null) throw new Exception("Houve um erro na atualização de contato!!");


            appDbContext.Name = login.Name;
            appDbContext.Password = login.Password;
            appDbContext.Email = login.Email;

            _appDbContext.Login.Update(appDbContext);
            _appDbContext.SaveChanges();

            return appDbContext;
        }

        public bool Apagar(int id)
        {
            Login appDbContext = BuscarPorId(id);

            if (appDbContext == null) throw new Exception("houve um erro na deleção de login");

            _appDbContext.Login.Remove(appDbContext);
            _appDbContext.SaveChanges() ;

            return true;
        }

    }
}
