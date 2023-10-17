using Carteira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Helpers
{
    public class Menu
    {
        public static void BoasVindas()
        {
            Console.WriteLine("\nBem vindo à sua Carteira Digital!");
        }
        public static void MenuPrincipal()
        {
            Console.WriteLine("1. Carteira");
            MenuCarteira(Convert.ToInt32(Console.ReadLine()));
        }

        public static void MenuCarteira(int opcao)
        {
            Console.Clear();
            if (opcao == 1)
            {
                Console.WriteLine("1. Cadastro");
                Console.WriteLine("2. Saldo");
                Console.WriteLine("3. Investimentos");
                Console.WriteLine("4. Pagamentos");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ClienteModel clienteModel = new();
                        break;
                    case 2:
                        //TODO: Chamar consulta de Saldo
                        break;
                    case 3:
                        //TODO: Chamar Carteira de Investimentos
                        break;
                    case 4:
                        //TODO: Chamar cadastro de Pagamento
                        break;
                    default:
                        throw new Exception("Opção inválida.");
                        break;
                }
            }
            else
            {
                throw new Exception("Opção inválida.");
            }
        }
    }
}
