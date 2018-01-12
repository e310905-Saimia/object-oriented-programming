using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personJouni = new Person();
            personJouni.Name = "Jouni K";
            Console.WriteLine($"Jounin ikä: {personJouni.GetAge()}");

            personJouni.GrowOld();
            Console.WriteLine($"Jounin ikä: {personJouni.GetAge()}");
            personJouni.GrowOld(50);
            personJouni.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();




        }
    }
}
