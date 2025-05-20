internal class Program
{
    private static void Main(string[] args)
    {
      
       
            string again = "yes";

            while (again == "yes" || again == "y")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());

               
                if (age < 13)
                {
                    Console.WriteLine(name + " is a Child.");
                }
                else if (age >= 13 && age < 20)
                {
                    Console.WriteLine(name + " is a Teenager.");
                }
                else if (age >= 20 && age < 60)
                {
                    Console.WriteLine(name + " is an Adult.");
                }
                else
                {
                    Console.WriteLine(name + " is a Senior Citizen.");
                }

              
                

                Console.Write("Do you want to continue? (yes/no): ");
                again = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Program ended.");
        }
    }

