using oops_inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog("buddy", 5, "labrador", "ball");
        Cat cat = new Cat("Fluffy",4, "persian", true);

        Console.WriteLine("dog details:");
        dog.DisplayDogdetails();
        Console.WriteLine("\n Cat details");
        cat.DisplayCatdetails();
    }
}