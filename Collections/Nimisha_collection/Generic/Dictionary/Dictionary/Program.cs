internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<int,string> Companies = new Dictionary<int, string>();
        Companies.Add(1,"Atrich");
        Companies.Add(2, "tcs");
        Companies.Add(3, "wipro");
        Console.WriteLine("the value of the key '1' is {0}",Companies[1]);
    }
}