using Carteira;
using System.Security.Cryptography.X509Certificates;

namespace Carteira;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Menu.BoasVindas();
            Menu.MenuCarteira(Menu.MenuPrincipal());

            Pessoa cliente1 = new Pessoa();

            Console.Write($"\nDocumento (CPF/CNPJ): ");
            cliente1.Documento = Console.ReadLine();

            Console.Write($"\nNome: ");
            cliente1.Nome = Console.ReadLine();

            Console.Write($"\nIdade: ");
            cliente1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(cliente1.Nome);
            Console.WriteLine(cliente1.Idade);
            Console.WriteLine(cliente1.Documento);

            Pagamento pagamento = new Pagamento();

            Console.WriteLine("Qual o nome do recebedor do pagamento?");
            pagamento.Recebedor = Console.ReadLine();

            pagamento.MostrarMetodoPagamento();
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