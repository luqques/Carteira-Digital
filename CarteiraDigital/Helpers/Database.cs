using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Helpers
{
    public class Database
    {
        protected string connectionString = "Server = localhost; Database = carteiradigital; User = root; Password = root;";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected int Execute(string sql, object obj)
        {
            using (MySqlConnection con = GetConnection())
            {
                return con.Execute(sql, obj);
            }
        }
    }
}
