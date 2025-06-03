
using Interface;
 class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("buddy",3,"labrdor","golden");
        Console.WriteLine($"my dog's name is {dog.Name},and its {dog.Age} years old");

        Cat cat = new Cat("whiskers",2,"persian","white");
        Console.WriteLine($"my cats name is {dog.Name},its {cat.Age} year old");
    }
}