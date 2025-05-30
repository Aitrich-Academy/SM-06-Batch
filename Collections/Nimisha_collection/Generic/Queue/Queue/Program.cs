internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> jobs = new Queue<string>();
        jobs.Enqueue("Dotnet developer");
        jobs.Enqueue("Java developer");
        jobs.Enqueue("Angular developer");
        Console.WriteLine("The first item in the queue is {0}",jobs.Peek());
        jobs.Dequeue();
        Console.WriteLine("The new first item in the queue is {0}",jobs.Peek());
    }
}