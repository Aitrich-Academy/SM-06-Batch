internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> skills = new Stack<string>();
        skills.Push("Dotnet");
        skills.Push("Java");
        skills.Push("Angular");

        Console.WriteLine("the top item on the stack is {0}",skills.Peek());
        skills.Pop();
        Console.WriteLine("the new top item on the stack is {0}",skills.Peek());
    }
}