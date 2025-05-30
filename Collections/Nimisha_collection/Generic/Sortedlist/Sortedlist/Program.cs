internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<string, int> jobs = new SortedList<string, int>();
        jobs.Add("Dotnet developer",1);
        jobs.Add("Java developer", 2);
        jobs.Add("Angular developer", 3);

        Console.WriteLine("The value of the key 'Dotnet developer' is {0}", jobs["Dotnet developer"]);
    }
}