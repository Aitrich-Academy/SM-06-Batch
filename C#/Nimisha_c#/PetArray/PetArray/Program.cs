internal class Program
{
    private static void Main(string[] args)
    {
        string[] petName = new string[10];
        Console.WriteLine("how many pet names you want to add to the array");
        int count = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<count;i++)
        {
            Console.WriteLine("enter the name of {0}th pet ",i+1);
            petName[i] = Console.ReadLine();

        }
        foreach (var pet in petName)
        {
            Console.WriteLine(pet);
        }
        Console.ReadLine();
    }
}
