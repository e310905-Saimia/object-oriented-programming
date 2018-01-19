using System;

namespace Exam5
{
    /// <summary>
    /// Exam 5: Read customer data and evaluate ticket price
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer data...");

            Console.Write("Enter name : ");
            var name = Console.ReadLine();
            var customer = new Customer(name);
            
            
            int age = -1;
            while (age < 0)
            {
                Console.Write("Enter age : ");
                if (!int.TryParse(Console.ReadLine(), out age)) 
                {
                    Console.WriteLine("Invalid age!");
                    age = -1;
                }
                else {
                    customer.Age = age;
                }
            }

            customer.IsMTKmember = YesNo("Is customer a member of MTK");
            customer.IsConscript = YesNo("Is customer a conscript");
            customer.IsStudent = YesNo("Is customer a student");

            Console.WriteLine($"Price for {customer.Name} is {customer.GetPrice():F2}");
            Console.ReadKey();
        }

        /// <summary>
        /// Accepts only Y or N as answer (ok, lowercase also accepted ;)
        /// </summary>
        /// <param name="prompt"> the question </param>
        /// <returns> true, if Y | false, if N </returns>
        private static bool YesNo(string prompt)
        {
            while (true)
            {
                Console.Write("{0} (Y/N) : ", prompt);
                char c = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (c == 'Y')
                {
                    return true;
                }
                if (c == 'N')
                {
                    return false;
                }
                Console.WriteLine("Please answer Y or N!");
            }
        }
    }
}
