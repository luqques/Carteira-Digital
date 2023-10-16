using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Model
{
    internal class ClienteModel : ICrud
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            try
            {
                string conectionString = "Server=localhost;Database=carteiradigital;User=root;Password=root;";
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
    }
}
