using Employee;
using System.Buffers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter Employee Type (Full/Part): ");
        string empType = Console.ReadLine().Trim().ToLower();

        Employ emp = null;
        Iprintable printableEmp = null;

        if (empType == "full")
        {
            emp = new FulltimeEmployee();
        }
        else if (empType == "part")
        {
            emp = new Parttimeemployee();
        }
        else
        {
            Console.WriteLine("Invalid Employee Type.");
            return;
        }

        Console.Write("Enter Employee ID: ");
        emp.EmployeeId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Base Salary: ");
        emp.BaseSalary = Convert.ToInt32(Console.ReadLine());

        emp.CalculateSalary();

        switch (emp)
        {
            case Iprintable printable:
                printable.PrintDetails();
                break;
        }
    }

}