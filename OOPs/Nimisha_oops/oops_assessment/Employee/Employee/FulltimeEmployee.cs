using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class FulltimeEmployee: Employ,Iprintable
    {
        private double totalSalary;

        public override double CalculateSalary()
        {
            totalSalary = BaseSalary + 5000;
            return totalSalary;
        }
        public void PrintDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: FullTimeEmployee");
            Console.WriteLine($"Base Salary: {BaseSalary}");
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}
