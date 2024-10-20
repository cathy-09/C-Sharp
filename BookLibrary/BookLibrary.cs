using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookLibrary
    {
        private string name;
        private List<Book> books;

        public BookLibrary(string name)
        {
            this.books = new List<Book>();
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }

        public void AddBook(string title, double rating)
        {
            Book newBook = new Book(title, rating);
            books.Add(newBook);
        }

        public double AverageRating()
        {
            double average = 0d;
            int count = 0;
            double totalRating = 0.0;
            for (int i = 0; i < this.books.Count; i++)
            {
                totalRating += this.books[i].Rating;
                count++;
            }
            average += (totalRating / count);
            return Math.Round(average, 2);

        }

        public List<string> GetBooksByRating(double rating)

        {
            List<string> bookWithRating = new List<string>();
            foreach (Book book in books)
            {
                if (book.Rating > rating)
                {
                    bookWithRating.Add(book.Title);
                }
            }
            return bookWithRating;
        }

        public List<Book> SortByTitle()
        {
            string titleTemp;
            double ratingTemp = 0d;
            //List<Book> sortedBook = new List<Book>();
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < books.Count - 1; i++)
                {
                    if (string.Compare(books[i].Title, books[i + 1].Title, true) > 0)
                    {
                        titleTemp = books[i].Title;
                        books[i].Title = books[i + 1].Title;
                        books[i + 1].Title = titleTemp;

                        ratingTemp = books[i].Rating;
                        books[i].Rating = books[i + 1].Rating;
                        books[i + 1].Rating = ratingTemp;

                        flag = true;
                    }
                }
            }
            return books;
        }

        public List<Book> SortByRating()
        {
            string titleTemp;
            double ratingTemp = 0d;
            //List<Book> sortedBook = new List<Book>();
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < books.Count - 1; i++)
                {
                    if (books[i].Rating < books[i + 1].Rating)
                    {
                        ratingTemp = books[i].Rating;
                        books[i].Rating = books[i + 1].Rating;
                        books[i + 1].Rating = ratingTemp;

                        titleTemp = books[i].Title;
                        books[i].Title = books[i + 1].Title;
                        books[i + 1].Title = titleTemp;

                        flag = true;
                    }
                }
            }
            return books;
        }

        public string[] ProvideInformationAboutAllBooks()
        {
            string[] bookInfo = new string[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                bookInfo[i] = $"{books[i].ToString()}";
            }
            return bookInfo;
        }

        public bool CheckBookIsInBookLibrary(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
