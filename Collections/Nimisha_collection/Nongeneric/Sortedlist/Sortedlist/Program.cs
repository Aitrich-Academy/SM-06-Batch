using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        SortedList pets = new SortedList();
        pets.Add("Parrot", "P1");
        pets.Add("Pigeon", "P2");
        pets.Add("Cat", "P3");
        pets.Add("Dog", "P4");
        pets.Add("Rabbit", "P5");
        pets.Remove("Pigeon");

        foreach (var item in pets)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"parrot is not found at index{pets.IndexOfKey("Parrot")}");
        Console.WriteLine($"value p5 is at indexx{pets.IndexOfValue("P5")}");
        Console.WriteLine($"length is:{pets.Count}");
    }
}