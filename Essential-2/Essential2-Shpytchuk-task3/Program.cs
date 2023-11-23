

namespace essential_2_task3
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Ivan", "Shpytchuk");
            string position = "tester";
            int exp = 3;

            SalaryCalculator calculator = new SalaryCalculator();
            double salary = calculator.CalculateSalary(position, exp);
            employee.DisplayEmployeeInfo(position, salary);
        }
    }
}
