using Carteira.Entity;
using Carteira.Model;
using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Helpers
{
    public class Menu
    {
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
                Console.WriteLine("1. Saldo");
                Console.WriteLine("2. Investimentos");
                Console.WriteLine("3. Pagamentos");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        //TODO: Chamar consulta de Saldo
                        break;
                    case 2:
                        //TODO: Chamar Carteira de Investimentos
                        break;
                    case 3:
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
