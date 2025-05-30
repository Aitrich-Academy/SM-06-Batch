using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Stack pets = new Stack();
        pets.Push("parrot");
        pets.Push("Pigeon");
        pets.Push("Cat");
        pets.Push("Dog");
        pets.Push("Rabbit");

        pets.Pop();

        foreach (var item in pets)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"length:{pets.Count}");
        Console.WriteLine("Enter item that you want to check");
        string check = Console.ReadLine();
        if (pets.Contains(check))
        {
            Console.WriteLine($"{check}  found");
        }
        else
        {
            Console.WriteLine($"{check} not found");
        }
    }
}