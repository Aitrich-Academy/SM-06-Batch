using Abstract;

internal class Program
{
    private static void Main(string[] args)
    {

        Dog dog = new Dog("buddy",4,"labrador");
        Cat cat = new Cat("whiskers", 6, "siamese");


        Console.WriteLine("dog:");
        Console.WriteLine($"Name:{dog.Name},Age:{dog.Age},Breed:{dog.Breed}");
        dog.MakeSound();



        Console.WriteLine("\n cat");
        Console.WriteLine($"Name:{cat.Name},Age:{cat.Age},Breed:{cat.Breed}");
        cat.MakeSound();
    }
}