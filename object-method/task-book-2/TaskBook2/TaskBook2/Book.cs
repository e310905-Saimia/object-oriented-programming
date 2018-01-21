using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public Book()
        {
            _name = "unknown";
            _author = "unknown";
            _publisher = "unknown";
            _price = 0;
            _category = "unknown";
            

        }

    }
}
