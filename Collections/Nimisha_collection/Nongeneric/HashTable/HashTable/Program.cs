using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable pets = new Hashtable();
        pets.Add("Parrot", "");
        pets.Add("Dog", "p2");
        pets.Add("Cat", "p3");
        pets.Add("Pigeon", "p4");
        pets.Add("Rabbit", "p5");
        foreach (DictionaryEntry entry in pets)
        {
            Console.WriteLine($"{entry.Key},{entry.Value}");
        }
        pets.Remove("Cat");
        Console.WriteLine("Updated HashTable");
        foreach (DictionaryEntry entry in pets)
        {
            Console.WriteLine($"{entry.Key},{entry.Value}");

        }
        Console.WriteLine($"Length is: {pets.Count}");

        Console.WriteLine("enter item to be checked");
        string check = Console.ReadLine();
        if (pets.Contains(check))
        {
            Console.WriteLine("item found"); 
        }
        else
        {
            Console.WriteLine("item not found");
        }
    }
}