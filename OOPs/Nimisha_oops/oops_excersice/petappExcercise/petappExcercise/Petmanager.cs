using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petappExcercise
{
    public class Petmanager : Ipet1
    {
        private int numpets = 0;
        private Pet[] pets = new Pet[10];
        public void addpet()
        {
            if (numpets == pets.Length)
            {
                Console.WriteLine("pets full");
                return;
            }

            Console.WriteLine("Pet Name: ");
            string petName = Console.ReadLine();
            Console.WriteLine("Species: ");
            string species = Console.ReadLine();
            Console.WriteLine("Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("owner: ");
            string Owner = Console.ReadLine();


            Pet newpet = new Pet(petName, species, Age, Owner);

            pets[numpets] = newpet;
            numpets++;
            Console.WriteLine("pet added successfully.");

        }
        //public void Listpet()
        //{
        //    Console.WriteLine("\n--- Pets in the System ---");
        //    for (int i = 0; i < numpets; i++)
        //    {
        //        pets[i].DisplayInfo();
        //    }

        //}
        public void Listpet()
        {
            if (numpets == 0)
            {
                Console.WriteLine("No pets added yet.");
                return;
            }

            Console.WriteLine("List of Pets:");
            for (int i = 0; i < numpets; i++)
            {
                Console.WriteLine($"Name: {pets[i].Name}");
                Console.WriteLine($" Species: {pets[i].Species}");
                Console.WriteLine($" Age: {pets[i].Age}");
                Console.WriteLine($" Owner: {pets[i].Owner}");
            }
        }
        public void SetFavoritePet()
        {
            if (numpets == 0)
            {
                Console.WriteLine("No pets to choose from.");
                return;
            }

            Console.WriteLine("Enter the name of the pet you want to set as favorite:");
            string favName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < numpets; i++)
            {
                if (pets[i].Name.ToLower() == favName.ToLower())
                {
                    for (int j = 0; j < numpets; j++)
                    {
                        pets[j].IsFavorite = false;
                    }

                    pets[i].IsFavorite = true;
                    Console.WriteLine($"{pets[i].Name} is now your favorite pet!");
                    found = true;
                    break;
                }
            }
        }
        public void RemoveFromFavorites()
        {
            Console.Write("Enter the name of the pet to remove from favorites: ");
            string favName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < numpets; i++)
            {
              
                //if (string.Equals(pets[i].Name, favName, StringComparison.OrdinalIgnoreCase))
                  //  {
                        if (pets[i].IsFavorite)
                    {
                        pets[i].IsFavorite = false;
                        Console.WriteLine($"{pets[i].Name} was removed from favorites.");
                    }
                    else
                    {
                        Console.WriteLine($"{pets[i].Name} is not marked as favorite.");
                    }

                    found = true;
                    break; 
                }
          //  }

            if (!found)
            {
                Console.WriteLine("Pet not found.");

            }
        }
    }
}
