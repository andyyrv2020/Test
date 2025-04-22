using System;
using System.Collections;
using System.Collections.Generic;

namespace Test5_Knijarnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, new List<string> { "George Orwell" });
            Book bookTwo = new Book("The Documents in the Case", 2002, new List<string> { "Dorothy Sayers", "Robert Eustace" });
            Book bookThree = new Book("The Documents in the Case", 1930, new List<string> { });

            Library library = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }

    class Book
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, List<string> authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public int Year
        {
            get { return year; }
            private set { year = value; }
        }
        public IReadOnlyList<string> Authors { get; private set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year} Authors: {string.Join(", ", this.Authors)}";
        }
    }

    class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
