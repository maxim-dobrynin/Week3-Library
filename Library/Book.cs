using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title; // variable
        private string author; // variable
        private string isbn; // variable

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        
        // Method to display imformation about a book
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
