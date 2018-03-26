using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp2
{
    class Bank
    {
        private List<Account> _accounts;
        private string _name;

        public Bank(string name)
        {
            _name = name;
            _accounts = new List<Account>();
        }

        public string CreateAccount()
        {
            Random rnd = new Random();
            string rndAccount = "FI";
            for (int i = 0; i < 16; i++)
            {
                rndAccount += rnd.Next(0,10);
            }
            _accounts.Add(new Account(rndAccount));
            return rndAccount;
        }

        public bool AddTransactionForCustomer(string accountNumber, Transaction transaction)
        {
            return (from account in _accounts
                where account.AccountNumber == accountNumber
                select account).First().AddTransaction(transaction);
        }

        public double GetBalanceForCustomer(string accountNumber)
        {
            return _accounts.FirstOrDefault(a => a.AccountNumber == accountNumber).Balance;
            //return (from account in _accounts
            //    where account.AccountNumber == accountNumber
            //    select account).FirstOrDefault().Balance;
        }

        public List<Transaction> GetTransactionsForCustomerForTimeSpan(string accountNumber, 
            DateTime startTime, DateTime endTime)
        {
            //return _accounts.FirstOrDefault(a => a.AccountNumber == accountNumber)
            //    .GetTransactionsForTimeSpan(startTime, endTime);

            return (from account in _accounts
                    where account.AccountNumber == accountNumber
                    select account).FirstOrDefault().GetTransactionsForTimeSpan(startTime, endTime);
        }
    }
}
