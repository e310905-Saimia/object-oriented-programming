﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TaskPerson
{
    class Program
    {

        static void Main(string[] args)
        {
            //Greate store where all persons are stored
            List<Person> persons = new List<Person>();
            persons = CreateData(persons);
            
            
            /*Phone phone = new Phone();
            
            Person personJouni = new Person();
            personJouni.Name = "Jouni K";
            Console.WriteLine($"Jounin ikä: {personJouni.GetAge()}");            

            personJouni.GrowOld();
            Console.WriteLine($"Jounin ikä: {personJouni.GetAge()}");
            personJouni.GrowOld(50);
            
            // Generoidaan kaksi uutta puhelin numeroa
            personJouni.PhoneNumbers(new Phone("0407227015"));
            personJouni
            //personJouni.PrintPersonInfo();

            // Lisätään henkilö taulukkoon
            persons.Add(personJouni);


            // Luodaan uusi henkilö
            Person newPerson = new Person("Joe Doe", 17,"0401234567");
            //newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            
            // Generoidaan yksi uusi puhelin numeroa
            
            //newPerson.PrintPersonInfo();

            // Lisätään henkilö taulukkoon
            persons.Add(newPerson);
           */

            PrintAll(persons);
           


            Person searchedPerson = FindPerson(persons,"Jouni K");
            if (searchedPerson == null)
                Console.WriteLine("Henkilöä ei löydy!");
            else
            {
                Console.WriteLine("Henkilö löytyi!");
                searchedPerson.PrintPersonInfo();
            }

            PrintAll(SortPersons(persons));

            //string s = new string('-',100);
            //Console.WriteLine(new string('-', 100));
            //Utils.Separator = "#";
            Console.WriteLine(Utils.Separator);

            Utils.SetSeparator('#',50);
            Console.WriteLine(Utils.Separator);

            Console.ReadKey();

        }

        public static void PrintAll(List<Person> persons)
        {
            foreach (var person in persons)
            {
                person.PrintPersonInfo();
            }
        }

        public static List<Person> CreateData(List<Person> persons)
        {
            
            Person p1 = new Person("Jouni K",50,Utils.GenerateNewRandomPhone());
            p1.Age = 51;
            p1.AddPhone("0407227015");
            p1.AddPhone(Utils.GenerateNewRandomPhone());
            persons.Add(p1);

            Person p2 = new Person("Mirja K", 40, Utils.GenerateNewRandomPhone());
            p2.AddPhone("0400755269");         
            persons.Add(p2);
            

            Person p3 = new Person("Sanni K", 9);
            p3.AddPhone("123123123");
            persons.Add(p3);
            return persons;

        }


        /// <summary>
        /// Lambda query example
        /// </summary>
        /// <param name="persons"></param>
        /// <param name="searchPersonByName"></param>
        /// <returns></returns>
        public static Person FindPerson(List<Person> persons, string searchPersonByName)
        {
            return persons.Find(p => p.Name.Equals(searchPersonByName));
        }

        public static List<Person> SortPersons(List<Person> persons)
        {
            List<Person> personOrdered = new List<Person>(persons.OrderByDescending(p => p.Name).ThenBy(p => p.Age));
            return personOrdered;
        }
    }
}
