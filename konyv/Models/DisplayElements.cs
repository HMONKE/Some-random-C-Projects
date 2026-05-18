using konyv.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyv.Models
{
    internal class DisplayElements
    {
        public static void ShowBooks(List<Book> books, Dictionary<int, string> categoryNames, ref ListView lv)
        {
            lv.Items.Clear();

            foreach (Book book in books)
            {
                ListViewItem lvi = new ListViewItem(categoryNames[book.CategoryId]);
                lvi.Name = book.Id.ToString();
                lvi.SubItems.Add(book.Author);
                lvi.SubItems.Add(book.Title);
                lvi.SubItems.Add(book.Description);
                lvi.SubItems.Add(book.Price.ToString());

                lv.Items.Add(lvi);
            }
        }
    }
}
