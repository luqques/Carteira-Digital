using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Helpers
{
    public class Login : Database
    {
        public static void RealizarLogin()
        {
            //TODO: Usar a classe Database para conexão com o Banco.

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
                    if (reader.Read())
                    {
                        isDocumentoExistente = true;
                    }
                }

                if (isDocumentoExistente == true)
                {
                    //TODO: Pedir a senha.
                }
                else
                {
                    Console.WriteLine("Conta não existente, deseja realizar o cadastro? s/n");
                    if (Convert.ToChar(Console.ReadLine().ToLower()) == 's')
                    {
                        //TODO: Realizar o cadastro.
                    }
                    else if (Convert.ToChar(Console.ReadLine().ToLower()) == 'n')
                    {
                        //TODO: Voltar ao Login.
                    }
                    else
                    {
                        throw new FormatException("Caractere inválido.");
                    }
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
    }
}
