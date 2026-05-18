using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyv.DataStructures;

namespace konyv.DataStructures
{
    internal class Book
    {
        private int id;
        private int categoryId;
        private string author;
        private string title;
        private string description;
        private int price;

        public int Id { get => id; }
        public int CategoryId { get => categoryId; }
        public string Author { get => author; }
        public string Title { get => title; }
        public string Description { get => description; }
        public int Price { get => price; }

        public Book(int id, int categoryId, string author, string title, string description, int price)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.author = author;
            this.title = title;
            this.description = description;
            this.price = price;
        }

        public Book(int categoryId, string author, string title, string description, int price)
        {
            this.categoryId = categoryId;
            this.author = author;
            this.title = title;
            this.description = description;
            this.price = price;
        }
    }
}