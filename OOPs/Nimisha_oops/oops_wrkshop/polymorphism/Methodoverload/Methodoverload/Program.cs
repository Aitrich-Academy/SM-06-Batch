using Methodoverload;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet mypet = new Pet("sss",4);
        Dog mydog = new Dog("buddy", 5, "daf");
        Console.WriteLine("my pet");
        mypet.DisplayInfo();
       Console.WriteLine("\nmy dog");
       mydog.DisplayInfo(true);

        PetSeller petSeller = new PetSeller("joshn", mypet);
        petSeller.SellPet();
    }
}