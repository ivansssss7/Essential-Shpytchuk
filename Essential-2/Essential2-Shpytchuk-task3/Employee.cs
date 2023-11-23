using System;

namespace essential_2_task3
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        private const double tax = 0.2;
        public void DisplayEmployeeInfo(string position, double salary)
        {
            Console.WriteLine($"Employee: {Name} {Surname}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Tax: {tax*100}%");
            Console.WriteLine($"Salary after tax: {CalculateSalaryAfterTax(salary)}");
        }
        private double CalculateTax(double salary)
        {
            return salary * tax;
        }

        private double CalculateSalaryAfterTax(double salary)
        {
            return salary - CalculateTax(salary);
        }
    }
}
