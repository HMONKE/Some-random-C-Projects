using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace konyv.DataBase
{
    
    internal class DataBaseHandler
    {
        private static MySqlConnection connection;
        private static MySqlConnectionStringBuilder connectionString;

        public static MySqlConnection Connection { get { return connection; } }

        static DataBaseHandler()
        {
            connectionString= new MySqlConnectionStringBuilder();
            connectionString.UserID = "root";
            connectionString.Password = "";
            connectionString.Server = "localhost";
            connectionString.Database = "bookstore";
            connectionString.CharacterSet = "utf8";
            connectionString.AllowZeroDateTime= true;
            connection = new MySqlConnection(connectionString.ConnectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


    }
}
