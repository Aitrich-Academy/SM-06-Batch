using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_eLAssesment
{
    using System;
    using System.Collections.Generic;

    public class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

       

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in items)
                total += item.TotalPrice;
            return total;
        }

        public void DisplayCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            Console.WriteLine("\nItems in cart:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name} | Price: {item.Price:C} | Quantity: {item.Quantity}");
            }
        }

        //public decimal ApplyDiscount(decimal percent)
        //{
        //    if (percent < 0 || percent > 100)
        //        throw new ArgumentException("Discount must be between 0 and 100.");

        //    decimal total = CalculateTotal();
        //    decimal discount = total * (percent / 100);
        //    decimal discountedTotal = total - discount;

        //}
    }

}
