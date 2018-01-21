using System;
using System.Collections.Generic;
using System.Text;
using TaskBook2;


namespace Literature
{
    class Author
    {
        private string _name;
        private string _bithday;
        private Book _book;

        public Author(string name, string bithday, Book book)
        {
            _name = name;
            _bithday = bithday;
            _book = book;
        }

        public void PrintData()
        {
            Console.WriteLine($"Kirjailija: {_name}\n" +
                              $"Syntymäpäivä: {_bithday}\n" +
                              $"Kirjat: ");
            _book.GetBook("Tuntematon sotilas");
        }
    }
}
