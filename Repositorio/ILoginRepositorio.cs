using System.Collections.Generic;
using ServiConnect.Models;




namespace ServiConnect.Repositorio
{
    public interface ILoginRepositorio
    {
         List<Login> BuscarTodos();
        Login  BuscarPorId (int id);
        Login Adicionar(Login login);
      
        Login Atualizar(Login login);

        bool Apagar(int id);
    }
}
