using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList pet = new ArrayList();
        pet.Add("Dog");
        pet.Add("Parrot");
        pet.Add("Cat");
        pet.Add("Rabbit");
        pet.Add("Pigeon");
        Console.WriteLine("ArrayList");
        foreach (var p in pet)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine($"Length:{pet.Count}");
        pet.Remove("Dog");
        pet.RemoveAt(0);
        pet[1] = "Dog";
        Console.WriteLine("Updated ArrayList");
        foreach (string p in pet)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine("enter name of pet that you want to check");
        string check = Console.ReadLine();
        if (pet.Contains(check))
        {
            Console.WriteLine("pet found");  
        }
        else
        {
            Console.WriteLine("pet not found");
        }
        foreach (string p in pet)
        {
            Console.WriteLine(p);
        }

        pet.Insert(3,"Dog");
        Console.WriteLine("updated arraylist");
        foreach (string p in pet)
        {
            Console.WriteLine(p);
        }
    }

}