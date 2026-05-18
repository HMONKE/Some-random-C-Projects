using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyv.DataStructures;

namespace konyv.DataStructures
{
    internal class BookCategory
    {
        private int id;
        private string name;

        public int Id { get => id; }
        public string Name { get => name; }

        public BookCategory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
