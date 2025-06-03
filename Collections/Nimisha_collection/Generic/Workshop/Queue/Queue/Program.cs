internal class Program
{
    private static void Main(string[] args)
    {

        Queue<string> pet = new Queue<string>();
        pet.Enqueue("Parrot");
        pet.Enqueue("Pigeon");
        pet.Enqueue("Rabbit");
        pet.Enqueue("Cat");
        pet.Enqueue("Cow");
        Console.WriteLine("Pet List");
        foreach (var item in pet)
        {
            Console.WriteLine(item); 
        }

        Console.WriteLine("first item in the queue is {0}",pet.Peek());
        pet.Dequeue();
        Console.WriteLine("First item in the Queue is {0}", pet.Peek());
        Console.WriteLine("Length is {0}", pet.Count);

    }
}