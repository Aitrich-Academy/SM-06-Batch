using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee
{
    public class Parttimeemployee:Employ
    {

        private double totalSalary;

        public override double CalculateSalary()
        {
            totalSalary = BaseSalary + 2000;
            return totalSalary;
        }
        public void PrintDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: Parttimeemployee");
            Console.WriteLine($"Base Salary: {BaseSalary}");
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}
