using System;

namespace Bban
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineFormat = BankUtil.CorrectNumber("227720-35988");
            Console.WriteLine(BankUtil.IsValidAccount(machineFormat));
        }
    }
}
