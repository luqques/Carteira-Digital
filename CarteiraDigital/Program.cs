using Carteira.Helpers;
using Carteira.Model;
using System.Security.Cryptography.X509Certificates;

namespace Carteira;

class Program
{
    static void Main(string[] args)
    {
        try
        {            
            Menu.Login();
            Menu.MenuPrincipal();
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato de caractere inválido!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado: " + ex);
        }
    }
}