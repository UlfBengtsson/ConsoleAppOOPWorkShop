using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPWorkShop.Models.Data
{
    class Book
    {
        private static int idCounter = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Auther Auther { get; set; }
        public int Pages { get; set; }

        public Book(string title, string isbn, Auther auther, int pages)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException($"'{nameof(title)}' cannot be null or empty.", nameof(title));
            }

            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentException($"'{nameof(isbn)}' cannot be null or empty.", nameof(isbn));
            }

            if (auther is null)
            {
                throw new ArgumentNullException(nameof(auther));
            }

            Title = title;
            ISBN = isbn;
            Auther = auther;
            Pages = pages;

            auther.books.Add(this);

            Id = ++idCounter;

        }
    }
}
