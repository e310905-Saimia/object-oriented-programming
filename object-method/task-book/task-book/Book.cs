using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook
{
    class Book
    {
        public string Title;
        private readonly string _author;
        public int Id;
        public double Price;

        //Constructor
        public Book()
        {
            Title = "Undefined";
            _author = "Undefined";
            Id = 0;
            Price = 0;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            _author = author;
            Id = id;
            Price = price;
        }

        public string CompareBook(Book book)
        {    
            if (this.Price > book.Price)
                return $"{this.Title} on kalliimpi kuin {book.Title} kirja";
            else
                return $"{book.Title} on kalliimpi kuin {this.Title} kirja";
            
        }

        public bool IsExpensier(Book book)
        {
            return (Price > book.Price);
        }
        // Methods
        public override string ToString()
        {
            var result = $"Kirjan nimi:\t{Title}\n" +
                         $"Kirjoittaja:\t{_author}\n" +
                         $"Id:\t\t{Id}\n" +
                         $"Kappalehinta:\t{Price:F}";
                                
            return result;
        }
    }
}
