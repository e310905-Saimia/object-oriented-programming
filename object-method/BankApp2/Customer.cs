using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp2
{
    class Customer
    {
        private string _accountNumber;
        public string FirstName { get; }
        public string LastName { get; }

        public Customer(string accountNumber, string firstName, string lastName)
        {
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
           
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

       
        public override string ToString()
        {
            return $"{FirstName} {LastName}\t{_accountNumber}";
        }
    }
}
