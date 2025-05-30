using Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet cat = new Pet("max", 3, "labrador");
        Pet dog = new Pet("whiskers",2,"persian");

        Pet[] petsforsale = { dog, cat };

        Petseller petseller = new Petseller(petsforsale);
        petseller.DisplayAvaliablePets();


        
    }
}