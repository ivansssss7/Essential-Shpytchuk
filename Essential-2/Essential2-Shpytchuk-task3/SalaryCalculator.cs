using System;

namespace essential_2_task3
{
    class SalaryCalculator
    {
        public double CalculateSalary(string position, int experience)
        {
            double baseSalary = GetBaseSalary(position);
            if (experience > 3)
            {
                baseSalary *= 1.5;
            }
            return baseSalary;
        }

        private double GetBaseSalary(string position)
        {
            double salary = 0;
            switch (position)
            {
                case "developer":
                    salary = 1500;
                    break;
                case "manager":
                    salary = 1000;
                    break;
                case "tester":
                    salary = 1200;
                    break;
                case "designer":
                    salary = 9000;
                    break;
                default:
                    Console.WriteLine("Невідома посада, неможливо вирахувати зарплату");
                    break;
            }
            return salary;
        }
    }
}
