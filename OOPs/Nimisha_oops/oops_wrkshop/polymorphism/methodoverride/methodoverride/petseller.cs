using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverride
{
    public class petseller:Pet
    {
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public petseller(string name,string breed,int age,decimal price)
            :base(name, age,breed)
        {
            this.price = price;

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"price:{price:C}");
        }
    }
    
}
