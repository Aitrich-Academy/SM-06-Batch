using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petappExcercise
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public bool IsFavorite { get; set; } = false;

        public Pet(string name, string species, int age, string owner)
        {
            Name = name;
            Species = species;
            Age = age;
            Owner = owner;
            IsFavorite = false;
        }

        //public void DisplayInfo()
        //{
        //    Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, Owner: {Owner}");
        //}
    }
}
