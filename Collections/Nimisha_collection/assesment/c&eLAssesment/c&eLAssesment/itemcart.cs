using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_eLAssesment
{
    public class Item
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }

        public Item(string name, int price, int quantity)
        {
            if (price < 0 || quantity < 0)


                throw new ArgumentException("Price and quantity must be non-negative.");


            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal TotalPrice => Price * Quantity;
    }

}
