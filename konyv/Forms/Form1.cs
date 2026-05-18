using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Molnar_Mate_Norbert.DataStructures;
using Molnar_Mate_Norbert.Models;

namespace Molnar_Mate_Norbert
{
    public partial class Form1 : Form
    {
        private BookHandler bh = new BookHandler();
        private BookCategoryHandler bch = new BookCategoryHandler();
        private Dictionary<int, string> categoryNames = new Dictionary<int, string>();
        private Dictionary<string, int> categoryIds = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }
    
        private void FillCategories()
        {
            List<BookCategory> categories = bch.GetCategories();
            foreach (BookCategory category in categories)
            {
                cmbCategory.Items.Add(category.Name);
                categoryNames.Add(category.Id, category.Name);
                categoryIds.Add(category.Name, category.Id);
            }
        }

        private void ShowBooks()
        {
            DisplayElements.ShowBooks(bh.GetBooks(), categoryNames, ref lvBooks);
        }

        private void ClearInputs()
        {
            txtAuthor.Text = "";
            txtTitle.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCategories();
            ShowBooks();
            btnUpdate.Enabled = false;
        }


        private void lvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBooks.SelectedItems.Count > 0)
            {
                Book book = bh.GetBookById(Convert.ToInt32(lvBooks.SelectedItems[0].Name));
                cmbCategory.Text = categoryNames[book.CategoryId];
                txtAuthor.Text = book.Author;
                txtTitle.Text = book.Title;
                txtDesc.Text = book.Description;
                txtPrice.Text = book.Price.ToString();
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                ClearInputs();
                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPrice.Text, out int price))
                {
                    throw new Exception("Az ár mezőbe csak számot lehet írni!");
                }
                Book book = new Book(
                        categoryIds[cmbCategory.Text],
                        txtAuthor.Text,
                        txtTitle.Text,
                        txtDesc.Text,
                        price
                        );
                bh.InsertBook(book);
                ClearInputs();
                ShowBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPrice.Text, out int price))
                {
                    throw new Exception("Az ár mezőbe csak számot lehet írni!");
                }
                Book book = new Book(
                        Convert.ToInt32(lvBooks.SelectedItems[0].Name),
                        categoryIds[cmbCategory.Text],
                        txtAuthor.Text,
                        txtTitle.Text,
                        txtDesc.Text,
                        price
                        );
                bh.UpdateBook(book);
                ClearInputs();
                ShowBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bh.DeleteBook(Convert.ToInt32(lvBooks.SelectedItems[0].Name));
            ShowBooks();
        }
    }
}
