using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Person
    {
       
        //Fields, attributes
        private string _name;
        private int _age;
        private List<Phone> _phoneNumbers;

        
        //Constructor
        public Person()
        {
            Name = "unknown";
            Age = 0;    
            _phoneNumbers=new List<Phone>();
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            _phoneNumbers = new List<Phone>();
        }

        public Person(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            _phoneNumbers = new List<Phone>();
            _phoneNumbers.Add(new Phone(phone));
        }
        // Properties
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

        private List<Phone> PhoneNumbers
        {
            get { return _phoneNumbers; }

            set { _phoneNumbers = value; }
        }

        // Methods
        public void AddPhone(string phonenumber)
        {
            _phoneNumbers.Add(new Phone(phonenumber));
            
        }
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
            Console.WriteLine($"Nimi: {Name}\n" +
                              $"Ikä: {Age}\n" +
                              $"Aikuinen: {IsAdult()}\n" +
                              $"Puhelin: ");

            GetPhones(PhoneNumbers);
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
        
        
        private void GetPhones(List<Phone> lstPhones)
        {
            //try
            //{
                foreach (var phone in lstPhones)
                {
                    Console.WriteLine(phone.PhoneNumber);
                }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("##########");
            //    //throw;
            //}
            
            Console.WriteLine("------------");
            
        }

    }
}
