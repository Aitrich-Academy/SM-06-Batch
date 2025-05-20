internal class Program
{
    private static void Main(string[] args)
    {
        
        string petName;
        int age;

        Console.WriteLine("enter the name of pet");
        petName = Console.ReadLine();
        Console.WriteLine("enter the age of pet");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Name :{0}\n Age of pet:{1}", petName, age);
        Console.ReadLine();
    }
}