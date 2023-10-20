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
using ZstdSharp.Unsafe;

namespace Carteira.Helpers
{
    public class Login : Database
    {
        private static Login _login = new();

        public ClienteEntity GetByDocumento(string documento) //jogar isso no ClienteModel (?)
        {
            _login.connectionString = base.connectionString;

            using (MySqlConnection con = new MySqlConnection(_login.connectionString))
            {
                string sql = $"SELECT * FROM CLIENTE WHERE DOCUMENTO LIKE '{documento}'";
                var parameters = new { Documento = documento };
                return con.QueryFirst<ClienteEntity>(sql, parameters);
            }
        }

        private static bool DocumentoExiste(string documento, string connectionString)
        {
            bool isDocumentoExistente = false;

            string sql = $"SELECT * FROM CLIENTE WHERE DOCUMENTO LIKE '{documento}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
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
            }
            return isDocumentoExistente;
        }

        public static void RealizarLogin()
        {
            Login login = new Login();

            Console.Write("Bem vindo à sua Carteira Digital! \n\nDigite seu documento (CPF/CNPJ): ");
            string documento = Console.ReadLine();

            if (DocumentoExiste(documento, _login.connectionString))
            {
                ClienteModel clienteExistente = new ClienteModel();
                //clienteExistente.Mostrar(login.GetByDocumento(documento));
                if (InserirSenha(login.GetByDocumento(documento)))
                {
                    Console.WriteLine("Entrou");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Não entrou!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Conta não existente, deseja realizar o cadastro? s/n");
                if (Convert.ToChar(Console.ReadLine().ToLower()) == 's')
                {
                    ClienteModel clienteNovo = new();
                    clienteNovo.Create();
                }
                else if (Convert.ToChar(Console.ReadLine().ToLower()) == 'n')
                {
                    Console.Clear();
                    Console.WriteLine("Volte sempre!");
                }
                else
                {
                    throw new FormatException("Caractere inválido.");
                }
            }
        }
        private static bool InserirSenha(ClienteEntity cliente)
        {
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (senha == cliente.Senha)
            {
                return true;
            }
            return false;
        }
    }
}
