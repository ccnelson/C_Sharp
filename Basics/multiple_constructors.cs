using System;

namespace Scratch2name
{
    class Scratch2
    {
        public class Employee
        {
            public int Salary;

            public Employee(int annualSalary)
            {
                Salary = annualSalary;
            }

            public Employee(int weeklySalary, int numberOfWeeks)
            {
                Salary = weeklySalary * numberOfWeeks;
            }
        }


        static void Main()
        {
            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);

            Console.WriteLine(e1.Salary);
            Console.WriteLine(e2.Salary);
        }
    }
}
