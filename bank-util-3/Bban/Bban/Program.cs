using System;
using DigiTrade.Utility;

namespace Bban
{
    class Program
    {
        static void Main(string[] args)
        {
            Bban newAcount = new Bban("227720A35988");
            //string machineFormat = newAcount.Bban1;
            //newAcount.IsMachineNumber = BankUtil.CorrectNumber(ref machineFormat);
            //newAcount.Bban1 = machineFormat;
            Console.WriteLine(newAcount.ToString());

            Bban account_2 = new Bban("123456-781");
            Console.WriteLine(account_2.ToString());


            //Console.WriteLine($"{newAcount.Bban1} - {newAcount.IsValid()}");

            //string machineFormat = "A227720-35988";
            //bool isMachineFormat = BankUtil.CorrectNumber(ref machineFormat);
            //if (isMachineFormat)
            //    Console.WriteLine($"{machineFormat} - {BankUtil.IsValidAccount(machineFormat)}");
            //else
            //    Console.WriteLine("Account number incorrect!");
        }
    }
}
