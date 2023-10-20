using Carteira.Entity;
using Carteira.Model;
using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
                InserirSenha(_login.GetByDocumento(documento));
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
        private static void InserirSenha(ClienteEntity cliente)
        {
            using (MySqlConnection connection = new MySqlConnection(_login.connectionString))
            {
                connection.Open();

                string sql = $"SELECT * FROM CLIENTE WHERE DOCUMENTO LIKE '{cliente.Documento}'";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string senha = reader["SENHA"].ToString();
                            if (senha == Console.ReadLine())
                            {
                                Console.WriteLine("Bem vindo à sua conta!");
                            }
                            else
                            {
                                Console.WriteLine("Senha incorreta! Tente novamente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Documento não cadastrado!");
                        }
                    }
                }

            }
        }
    }
}
