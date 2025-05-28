using ServiConnect.Models;

namespace ServiConnect.Repositorio
{
    public interface ILoginRepositorio
    {
        LoginModel BuscarPorEmail(string email);
        List<LoginModel> BuscarTodos();

        LoginModel BuscarPorId(int id);

        LoginModel Adicionar(LoginModel login);

        LoginModel Atualizar(LoginModel login);
        
        bool Apagar (int id);
    }
}
