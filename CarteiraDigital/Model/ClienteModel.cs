using MySql.Data.MySqlClient;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carteira.Entity;

namespace Carteira.Model
{
    internal class ClienteModel : ICrud
    {
        string conectionString = "Server=localhost;Database=carteiradigital;User=root;Password=root;";

        public void Create()
        {
            ClienteEntity cliente = new ClienteEntity();
            Console.WriteLine("Digite o número do documento do Cliente");
            cliente.Documento = Console.ReadLine();

            using (MySqlConnection connection = new MySqlConnection(conectionString))
            {
                string sql = $"INSERT INTO CLIENTE VALUE (NULL, {cliente.Documento}, )";
                int linhas = connection.Execute(sql, cliente);
                Console.WriteLine($"Cliente inserido - {linhas} linhas inseridas");
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {            
            using (MySqlConnection con = new MySqlConnection(conectionString))
            {
                IEnumerable<ClienteEntity> clientes = con.Query<ClienteEntity>("SELECT ID as Id, NOME as Nome FROM CLIENTE");
                foreach(ClienteEntity cliente in clientes)
                {
                    cliente.Mostrar();
                }
            }
        }

        public void ReadModoRuim()
        {
            try
            {
                MySqlConnection conection = new MySqlConnection(conectionString);
                conection.Open();
                string commandSql = "SELECT * FROM CLIENTE";
                MySqlCommand command = new MySqlCommand(commandSql, conection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Conectado");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["ID"]} - {reader["NOME"]} | {reader["DOCUMENTO"]} | {reader["TIPO_CLIENTE"]}");
                    }
                }
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro MySql");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado");
                Console.WriteLine(ex.Message);
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void DefinirTipoCliente()
        {
            Console.Clear();
            Console.Write("Digite o número identificador do seu documento: ");
             = Console.ReadLine();

            if (tipoCliente == 'J')
            {
                Empresa empresa1 = new Empresa();
            }
            else if (tipoCliente == 'F')
            {
                Pessoa pessoa1 = new Pessoa();
            }
        }
        private void Mostrar()
        {
            Console.WriteLine($"{Id} - {Nome}");
        }
    }
}
