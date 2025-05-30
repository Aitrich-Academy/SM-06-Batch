using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance
{
    public class Dog : Pet
    {
        private string favoritetoy;
        public Dog(string name, int age, string breed, string favoritetoy): base(name,age,breed)
        {
            this.favoritetoy=favoritetoy;

        }
        public void DisplayDogdetails()
        {
            Displaydetails();
            Console.WriteLine($"favoritetoy:{favoritetoy}");
        }
    }
}
