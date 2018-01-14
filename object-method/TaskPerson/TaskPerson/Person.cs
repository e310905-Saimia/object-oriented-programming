using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Person
    {
        //Fields
        private string _name;
        private int _age;

        //Constructor
        public Person()
        {
            Name = "unknown";
            Age = 0;            
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;            
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // Methods
        public void GrowOld()
        {
            Age++;
        }

        public void GrowOld(int number)
        {
            Age += number;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi: {name}\n" +
                              $"Ikä: {Age}\n" +
                              $"Aikuinen: {IsAdult()}");
        }

        public bool IsAdult()
        {
            //return (_age >= 18);

            if (Age >= 18)
                return true;
            else
                return false;
        }

        public int GetAge()
        {
            return Age;
        }
    }
}
