using System;
using Literature;


namespace TaskBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Häräntappo ase", "Anna-Leena Härkönen", "Otava", 10, "Draama");

            Console.WriteLine("Book luokan testeri!");
            Console.WriteLine($"Kategoria nyt: {Book.Category}");
            Book.ChangeCategory("Huumori");
            Console.WriteLine($"Kategoria nyt: {Book.Category}");

            Book book2 = new Book("Tuntematon sotilas", "Väinö Linna", "Otava", 100, "Sota");


            book1.GetBook("Tuntematon sotilas");
            book2.GetBook("Tuntematon sotilas");


            Console.WriteLine(book1.Author);

            Author author = new Author("Väinö XXX", "12.12.1934", book2);
            author.PrintData();
        }

        public static Book[] GreateData(Book[] books)
        {            
            books[0]=new Book("Häräntappo ase", "Anna-Leena Härkönen", "Otava", 10,"Draama");
            books[1] = new Book("Tuntematon sotilas", "Väinö Linna", "Otava", 100, "Sota");
            books[2] = new Book("Sinuhe egyptiläinen", "Mika Waltari", "Otava", 25, "Draama");
            books[3] = new Book("Uhrilento", "Ilkka Remes", "VSOY", 25, "Jännitys");
            books[4] = new Book("Mielensäpahoittaja", "", "Otava", 50, "Huumori");

            return books;
        }
    }
}
