using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Queue pets = new Queue();
        pets.Enqueue("Parrot");
        pets.Enqueue("Cat");
        pets.Enqueue("Pigeon");
        pets.Enqueue("Dog");
        pets.Enqueue("Rabbit");
        pets.Dequeue();

        foreach (var item in pets)
        {
            Console.WriteLine(item);   
        }
        Console.WriteLine(pets.Peek());
        Console.WriteLine($"length is:{pets.Count}");
    }
}