using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyv.DataBase;
using konyv.DataStructures;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace konyv.Models
{
    internal class BookHandler
    {
        private static MySqlConnection connection = DataBaseHandler.Connection;

        private bool CheckTitle(string title, bool update = false, int id = 0)
        {
            bool exists = false;

            if (!update)
            {
                string sql = "SELECT Count(id) as CheckTitle FROM books WHERE Title = @Title";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", title);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader["CheckTitle"]) == 1)
                            {
                                exists = true;
                            }
                        }
                    }
                }
            }
            else
            {
                string sql = "SELECT COUNT(id) as CheckTitle FROM books WHERE Title = @Title AND ID != @ID";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader["CheckTitle"]) == 1)
                            {
                                exists = true;
                            }
                        }
                    }
                }
            }

            return exists;
        }

        private void CheckErrors(Book book, bool update = false)
        {
            string errors = "";
            if (CheckTitle(book.Title, update, book.Id))
            {
                errors += "Már létezik ilyen elnevezésű könyv az adatbázisban!\n";
            }
            if (book.Price < 0)
            {
                errors += "Az ár nem lehet negatív!\n";
            }
            if (book.Description.Length < 20)
            {
                errors += "A leírásnak legalább 20 karakteresnek kell lennie!\n";
            }
            if (book.CategoryId == 0)
            {
                errors += "Nem választott kategóriát!\n";
            }
            if (book.Author == "")
            {
                errors += "Nem töltötte ki a szerző mezőt!\n";
            }
            if (book.Title == "")
            {
                errors += "Nem töltötte ki a cím mezőt!\n";
            }
            if (book.Description == "")
            {
                errors += "Nem töltötte ki a leírás mezőt!\n";
            }
            if (errors.Length > 0)
            {
                throw new Exception(errors);
            }
        }

        public void InsertBook(Book book)
        {
            CheckErrors(book);

            string sql = "INSERT INTO books (Category_ID, Author, Title, Description, price) " +
                "VALUES (@Category_ID, @Author, @Title, @Description, @price);";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Category_ID", book.CategoryId);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Description", book.Description);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBook(Book book)
        {
            CheckErrors(book, true);

            string sql = "UPDATE books SET Category_ID = @Category_ID, Author = @Author, Title = @Title, " +
                "Description = @Description, price = @price WHERE ID = @ID;";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Category_ID", book.CategoryId);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Description", book.Description);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@ID", book.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBook(int id)
        {
            string sql = "DELETE FROM books WHERE ID = @ID;";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            string sql = "SELECT * FROM books;";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book(
                            Convert.ToInt32(reader["ID"]),
                            Convert.ToInt32(reader["Category_ID"]),
                            reader["Author"].ToString(),
                            reader["Title"].ToString(),
                            reader["Description"].ToString(),
                            Convert.ToInt32(reader["price"])
                            );

                        books.Add(book);
                    }
                }
            }

            return books;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in GetBooks())
            {
                if (id == book.Id)
                {
                    return book;
                }
            }

            return new Book(0, 0, "", "", "", 0);
        }
    }
}
