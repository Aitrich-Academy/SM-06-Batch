using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance
{
    public class Pet
    {
        protected string name;
        protected int age;
        protected string breed;

        public Pet( string name,int age,string breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }
        public void Displaydetails()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"age:{age}");
            Console.WriteLine($"Breed:{breed}");
        }
            
    }
}
