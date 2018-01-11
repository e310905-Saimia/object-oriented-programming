using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personJouni = new Person();
            personJouni.Name = "Jouni K";
            personJouni.GrowOld();
            personJouni.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();




        }
    }
}
