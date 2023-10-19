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
        public static void Login()
        {
            string conectionString = "Server = localhost; Database = carteiradigital; User = root; Password = root;";

            Console.Write("Bem vindo à sua Carteira Digital! \n\nDigite seu documento (CPF/CNPJ): ");
            string documento = Console.ReadLine();
            bool isDocumentoExistente = false;

            string sql = $"SELECT * FROM CLIENTE WHERE DOCUMENTO LIKE '{documento}'";
            using (MySqlConnection connection = new MySqlConnection(conectionString))
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        isDocumentoExistente = true;
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }

                if (isDocumentoExistente == true)
                {
                    Console.WriteLine("Existe");
                }
                else
                {
                    Console.WriteLine("Não existe");
                }
            }

            if (Convert.ToChar(Console.ReadLine().ToLower()) == 's')
            {
                Console.Clear();
                
            }
            else if (Convert.ToChar(Console.ReadLine().ToLower()) == 'n')
            {
                Console.Clear();
                //TODO: Realizar Cadastro
            }
            else
            {
                throw new FormatException("Resposta inválida!");
            }
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
                        clienteModel.Read();
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
