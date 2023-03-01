using BLL;
using Models;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuario.Nome = "Luciano Miranda Da Silva";
            usuario.NomeUsuario = "luciano";

            Console.WriteLine("O usuario estara ativo(S) ou(N)");
            usuario.Ativo = Console.ReadLine().ToUpper() == "S";

            usuario.Email = "lucianomirandadasilva94@gmail.com";
            usuario.CPF = "048.517.201-14";
            usuario.Senha = "123425428";

            usuarioBLL.Inserir(usuario);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        
    } 
}