using Carteira;
using Carteira.Model;
using System.Security.Cryptography.X509Certificates;

namespace Carteira;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ClienteModel clienteModel = new ClienteModel();

            clienteModel.Read();

            clienteModel.Create();

            clienteModel.Read();

            Menu.BoasVindas();
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