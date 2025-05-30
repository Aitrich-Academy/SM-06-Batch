using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance
{
    public class Cat : Pet
    {
        private bool islonghair;

        public Cat(string name,int age,string breed, bool islonghair):base(name,age,breed)
        {
            this.islonghair = islonghair;
        }
        public void DisplayCatdetails()
        {
            Displaydetails();
            Console.WriteLine($"long hair:{islonghair}");
        }
    }
}
