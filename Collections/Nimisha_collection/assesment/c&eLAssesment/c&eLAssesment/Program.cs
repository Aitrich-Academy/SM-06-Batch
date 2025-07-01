using c_eLAssesment;

internal class Program
{
    private static void Main(string[] args)
    {
       
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("\n1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Display Cart");
                Console.WriteLine("5. Calculate Total");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter item name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter price: ");
                            int price = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter quantity: ");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                        cart.AddItem(new Item(name, price, quantity));
                            break;



                        case "2":
                            Console.Write("Enter item name to remove: ");
                            string itemName = Console.ReadLine();
                            //cart.RemoveItem(itemName);
                            Console.WriteLine("Item removed.");
                            break;




                        case "3":
                            //Console.Write("Enter discount %: ");
                            //decimal discount = decimal.Parse(Console.ReadLine());
                            //decimal discountedTotal = cart.ApplyDiscount(discount);
                            //Console.WriteLine($"Total after {discount}% discount: {discountedTotal:C}");
                            break;



                        case "4":
                            cart.DisplayCart();
                            break;


                        case "5":
                            Console.WriteLine($"Total Price: {cart.CalculateTotal():C}");
                            break;


                        case "6":
                            return;


                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }


                catch (ItemNotFoundException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter numeric values for price, quantity, or discount.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Input error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }
    }

