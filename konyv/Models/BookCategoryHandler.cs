using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using konyv.DataBase;
using konyv.DataStructures;
using MySql.Data.MySqlClient;

namespace konyv.Models
{
    internal class BookCategoryHandler
    {
        private static MySqlConnection connection = DataBaseHandler.Connection;

        public List<BookCategory> GetCategories()
        {
            List<BookCategory> categories = new List<BookCategory>();

            string sql = "SELECT * FROM category;";
            using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BookCategory category = new BookCategory(Convert.ToInt32(reader["id"]), reader["name"].ToString());
                        categories.Add(category);
                    }
                }
            }
            return categories;
        }
    }
}
