using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServiConnect.Models;

namespace ServiConnect.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly AppDbContext _context;

        public LoginRepositorio (AppDbContext context)
        {
            this._context = context;
        }

        public LoginModel BuscarPorEmail(string Email)
        {
            return _context.Login.FirstOrDefault(x => x.Email.ToUpper() == Email.ToUpper());
        }

        public LoginModel BuscarPorId(int id)
        {
            return _context.Login.FirstOrDefault(x => x.Id == id);
        }

        public List<LoginModel> BuscarTodos()
        {
            return _context.Login.ToList();
        }

        public LoginModel Adicionar(LoginModel login)
        {
            _context.Login.Add(login);
            _context.SaveChanges();
            return login;
        }

        public LoginModel Atualizar(LoginModel login)
        {
            LoginModel loginDb = BuscarPorId(login.Id);

            if (loginDb == null) throw new Exception("houve um erro na atualização do login");

            loginDb.Name = login.Name;
            loginDb.Email = login.Email;
            loginDb.Perfil = login.Perfil;

            _context.Login.Update(loginDb);
            _context.SaveChanges();

            return loginDb;
        }

        public bool Apagar(int id)
        {
            LoginModel loginDb = BuscarPorId(id);

            if (loginDb == null) throw new Exception("Houve um erro para deletar o Login");

            _context.Login.Remove(loginDb);
            _context.SaveChanges();

            return true;
        }

        public LoginModel BuscarPorEmailEName(string Name, string Email)
        {
            return _context.Login.FirstOrDefault(x => x.Name.ToUpper() == Name.ToUpper() &&  x.Email.ToUpper() == Email.ToUpper());
        }
    }
}
