internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> pet = new Dictionary<int, string>();

        pet.Add(1, "Parrot");
        pet.Add(2,"Pigeon");
        pet.Add(3, "Rabbit");
        pet.Add(4, "Cat");
        pet.Add(5, "Dog");

        foreach (KeyValuePair<int,string> item in pet)
        {
            Console.WriteLine($"key is {item.Key} and value is{item.Value}");   
        }

        pet.Remove(3);

        Console.WriteLine("Updated Dictionary");

        foreach (KeyValuePair<int,string> item in pet)
        {
            Console.WriteLine($"key is {item.Key} and value is{item.Value}");
        }
    }
}