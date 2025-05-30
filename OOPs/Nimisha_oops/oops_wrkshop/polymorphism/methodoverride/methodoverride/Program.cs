using System;
using methodoverride;

internal class Program
{
    private static void Main(string[] args)
    {

        petseller pet1 = new petseller("buddy","lasdsd",3,400);
        petseller pet2 = new petseller("bdy", "frdsd", 4, 500);
        Console.WriteLine("pet 1 detail");
        pet1.Display();
        Console.WriteLine("pet 2 detail");
        pet2.Display();

    }
}