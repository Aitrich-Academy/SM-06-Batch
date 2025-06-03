using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<string, string> pet = new SortedList<string, string>();
        pet.Add("Parrot", "Green");
        pet.Add("Pigeon", "White");
        pet.Add("Rabbit", "Grey");
        pet.Add("Cat", "White");
        pet.Add("Dog", "Black");
        Console.WriteLine("Sorted PetList");
        foreach (KeyValuePair<string, string> item in pet)
        {
            Console.WriteLine($"Pet {item.Key} is {item.Value}");
        }
        pet.Remove("Rabbit");
        Console.WriteLine("Updated Sorted PetList");
        foreach (KeyValuePair<string, string> item in pet)
        {
            Console.WriteLine($"Pet {item.Key} is {item.Value}");
        }
        Console.WriteLine("Enter Pet that you want to check");
        string check = Console.ReadLine();
        if (pet.ContainsKey(check))
        {
            Console.WriteLine($"{check} found");
        }
        else
        {
            Console.WriteLine($"{check} not found");
        }
    }
}