namespace TaskEmployee
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Position;
        public double Salary;

        public Employee()
        {
            Name = "Joe Doe";
            Id = 1;
            Position = "Boss";
            Salary = 100;
        }

        public Employee(string name, int id, string position, double salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        // Copy constructor
        public Employee(Employee employee)
        {
            Name = employee.Name;
            Id = employee.Id;
            Position = employee.Position;
            Salary = employee.Salary;
        }

        // Methods


    }
}
