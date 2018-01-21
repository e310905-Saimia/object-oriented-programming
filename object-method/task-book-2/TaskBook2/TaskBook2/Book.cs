using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TaskBook2
{
    class Book
    {
        private string _name;
        private string _author;
        private string _publisher;
        private double _price;
        private static string _category;

        /// <summary>
        /// Contructor
        /// </summary>
        public Book()
        {
            Name = "unknown";
            Author = "unknown";
            Publisher = "unknown";
            Price = 0;
            _category = "unknown";
        }

        public Book(string name, string author, string publisher, double price, string category)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            Price = price;
            _category = category;
        }


        /// <summary>
        /// Encapsulated properties
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 30)
                    _price = value * 0.9;
                else
                    _price = value;
            }
        }

        public static string Category
        {
            get { return _category; }
            //set { _category = value; }
        }

        public void GetBook(string name)
        {
            if (Name == name)
            {
                Console.WriteLine($"Kirja: {Name}\n" +
                                  $"Kijailija: {Author}\n" +
                                  $"Julkaisija: {Publisher}\n" +
                                  $"Hinta: {Price}\n" +
                                  $"----------------------");
            }
            else
            {
                Console.WriteLine($"{name} kirjaa ei löydy!");
            }
        }

        public static void ChangeCategory(string category)
        {
            _category = category;
        }
    }
}

