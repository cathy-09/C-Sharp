using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        private BookLibrary library;
        public Form1()
        {
            InitializeComponent();
            library = new BookLibrary("My Library");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            if (double.TryParse(txtRating.Text, out double rating))
            {
                library.AddBook(title, rating);
                UpdateBookList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please enter a valid rating.");
            }
        }
        private void UpdateBookList()
        {
            listBoxLibrary.Items.Clear();
            foreach (string bookInfo in library.ProvideInformationAboutAllBooks())
            {
                listBoxLibrary.Items.Add(bookInfo);
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtRating.Clear();
        }

        private void btnSortByTitle_Click(object sender, EventArgs e)
        {
            library.SortByTitle();
            UpdateBookList();

        }

        private void btnSortByRating_Click(object sender, EventArgs e)
        {
            library.SortByRating();
            UpdateBookList();
        }

        private void btnCheckBook_Click(object sender, EventArgs e)
        {
            string title = txtTitleCheck.Text;
            if (library.CheckBookIsInBookLibrary(title))
            {
                lblRez.Text = $"Book '{title}' is available in the library.";
            }
            else
            {
                MessageBox.Show($"Book '{title}' is not found.");
            }
        }

        private void btnAverageRating_Click(object sender, EventArgs e)
        {
            double average = library.AverageRating();
            lblRez.Text = $"The average rating of books is {average:F1}";
        }

        private void btnGetBooksByRating_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHigherRating.Text, out double rating))
            {
                var booksByRating = library.GetBooksByRating(rating);
                string result = string.Join("\n", booksByRating);
                lblRez.Text = $"Books with rating higher than {rating}:\n{result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid rating.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRating.Text = "";
            txtTitleCheck.Text = "";
            txtTitle.Text = "";
            txtHigherRating.Text = "";
            lblRez.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
