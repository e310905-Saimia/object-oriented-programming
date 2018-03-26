using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp2
{
    class Account
    {
        private string _accountNumber;
        private double _balance;
        private List<Transaction> _transactions;

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        public Account(string accountNumber, double balance, List<Transaction> transactions)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            _transactions = transactions;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        public bool AddTransaction(Transaction transaction)
        {
            bool res = false;

            _transactions.Add(transaction);
            double balanceBeforeTransaction = Balance;
            if (_transactions.Last().Equals(transaction))
            {
                Balance += transaction.Sum;
            }
            if (Balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }
            return res;
        }

        public List<Transaction> GetTransactionsForTimeSpan(DateTime startTime, DateTime endTime)
        {
            List<Transaction> res = (from transaction in _transactions
                                     where transaction.TimeStamp >= startTime && transaction.TimeStamp <= endTime
                                     orderby transaction.TimeStamp
                                     select transaction).ToList();

            //List<Transaction> res = (_transactions
            //    .Where(t => t.TimeStamp >= startTime && t.TimeStamp <= endTime)
            //    .OrderBy(t => t.TimeStamp)).ToList();


            return res;
        }
    }
}
