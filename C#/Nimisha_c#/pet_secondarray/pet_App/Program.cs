using pet_App.Enum;
internal class Program
{
    struct Pet{
        public int id;
        public string petname;
        public petCategory Category;

    }
    private static void Main(string[] args)
    {
        Pet[] pets = new Pet[10];
        Console.WriteLine("how many pets do you want to add");
        int count = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < count; i++)
        {
            Pet pet = new Pet();
            pet.id = i + 1;
            Console.WriteLine("Enter the name of the {0}th pet: ", i + 1);
            pet.petname = Console.ReadLine();


            int choice;
            bool validChoice;
            do
            {
                Console.WriteLine("Choose a number corresponding to category:");
                Console.WriteLine("1. Dog\n2. Cat\n3. Bird\n4. Fish\n5. Reptile\n6. Other");

                choice = Convert.ToInt32(Console.ReadLine());
                validChoice = true;

                switch (choice)
                {
                    case 1:pet.Category = petCategory.dog; break;
                    case 2: pet.Category = petCategory.cat; break;
                    case 3: pet.Category = petCategory.bird; break;
                    case 4: pet.Category = petCategory.fish; break;
                    case 5: pet.Category = petCategory.reptile; break;
                    case 6: pet.Category = petCategory.other; break;
                    default:
                        Console.WriteLine("Invalid choice, please re-enter the choice.");
                        validChoice = false;
                        break;
                }
            } while (!validChoice);
            pets[i] = pet;
        }

        Console.WriteLine("\nPet Details are:");
        foreach (var p in pets)
        {
            if (p.petname!=null)
            {
                Console.WriteLine("-------------- {0} -----------------", p.petname);
                Console.WriteLine("Pet Id: {0}", p.id);
                Console.WriteLine("Pet Name: {0}", p.petname);
                Console.WriteLine("Pet Category: {0}", p.Category);
            }
        }

        Console.ReadLine();
    }
}
