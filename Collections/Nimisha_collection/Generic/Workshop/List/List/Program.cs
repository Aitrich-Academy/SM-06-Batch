internal class Program
{
    private static void Main(string[] args)
    {
        List<string> myskills = new List<string>();
        myskills.Add("Dotnet");
        myskills.Add("Java");
        myskills.Add("Angular");

        myskills.Remove("Java");
        Console.WriteLine("my skills are");

        foreach (var item in myskills)
        {
            Console.WriteLine(item);   
        }

    }
}