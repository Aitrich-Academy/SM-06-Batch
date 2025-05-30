internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> pet = new Stack<string>();
        pet.Push("Parrot");
        pet.Push("Pigeon");
        pet.Push("Cat");
        pet.Push("Rabbit");
        pet.Push("Dog");
        Console.WriteLine("Pet List");
        foreach (var item in pet)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Length is :{pet.Count}");
        Console.WriteLine($"First item in the Stack is {pet.Peek()}");
        Console.WriteLine("Enter pet name that you want to check ");
        string check = Console.ReadLine();
        if (pet.Contains(check))
        {
            Console.WriteLine($"{check} found");
        }
        else
        {
            Console.WriteLine($"{check} not found");
        }
    }
}