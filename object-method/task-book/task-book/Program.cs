﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();
            Console.WriteLine(newBook.ToString());
            Book book2 = new Book();
            book2.Price = 10;
            book2.Title = "xxx";
            book2.Id = 1;

            Book book3 = new Book("Testi","Masa", 100, 29.00);

            Console.WriteLine(book2.CompareBook(book3));
            Console.WriteLine(book3.ToString());
            /*if (newBook.IsExpensier(book2))
                Console.WriteLine($"{newBook.Title} on kallimpi kuin {book2.Title} kirja");
            else
            {
                Console.WriteLine($"{book2.Title} on kallimpi kuin {newBook.Title} kirja");
            }
            */
            Console.ReadKey();

        }
    }
}
