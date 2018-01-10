using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee [] employees = new Employee[4];
            employees[0]=new Employee("Jouni", 2, "Teacher", 200);
            employees[1] = new Employee("Masa", 3, "Teacher", 200);
            employees[2] = new Employee();
            employees[3] = new Employee(employees[0]);

            Console.ReadKey();




        }
    }
}
