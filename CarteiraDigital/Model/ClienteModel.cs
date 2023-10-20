using MySql.Data.MySqlClient;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carteira.Entity;
using Carteira.Interfaces;
using Carteira.Helpers;

namespace Carteira.Model
{
    public class ClienteModel : ICrud
    {
        protected string connectionString = "Server = localhost; Database = carteiradigital; User = root; Password = root;";
        public void Create()
        {
            ClienteEntity cliente = new ClienteEntity();
            Console.WriteLine("Digite o número do documento do Cliente");
            cliente.Documento = Console.ReadLine();

            cliente.tipoCliente = DefinirTipoCliente(cliente.Documento);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"INSERT INTO CLIENTE VALUE ({cliente.Documento}, {cliente.tipoCliente})";
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
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    IEnumerable<ClienteEntity> clientes = con.Query<ClienteEntity>($"SELECT ID as Id, DOCUMENTO as Documento FROM CLIENTE");
                    foreach (ClienteEntity cliente in clientes)
                    {
                        Mostrar(cliente);
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

        private char DefinirTipoCliente(string documento)
        {                      
            if (documento.Length == 14)
            {
                return 'J';
            }
            else if (documento.Length == 11)
            {
                return 'F';
            }
            else
            {
                throw new Exception("Quantidade de dígitos de documento inválido.");
            }
        }
        public void Mostrar(ClienteEntity cliente)
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Documento}");
        }
    }
}
