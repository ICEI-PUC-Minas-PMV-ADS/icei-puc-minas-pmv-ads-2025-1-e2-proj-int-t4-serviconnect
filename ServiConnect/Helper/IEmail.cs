namespace ServiConnect.Helper
{
    public interface IEmail
    {
        bool Enviar(string Email, string assunto, string mensagem);
    }
}
