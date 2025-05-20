using System;
using System.Data;
using pet_Excercise.Enum;
internal class Program
{
    struct User
    {
        public int Id;
        public string Name;
        public string Email;
        public string Password;
        public string ContactDetails;
        public string Address;
        public string City;
        public string State;
        public role UserRole;
    }
    struct Pet
    {
        public int Id;
        public string Name;
        public string Category;
        public int OwnerId;
    }


    private static void Main(string[] args)
    {
        User[] users = new User[10];
        Pet[] pets = new Pet[50];
        int petCount = 0;
        User user = new User();
        int choice;
        do
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Logout");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    Console.WriteLine("\n------ User Registration ------");

                    Console.WriteLine("Enter the name ");
                    user.Name = Console.ReadLine();
                    Console.WriteLine("Enter the email");
                    user.Email = Console.ReadLine();
                    Console.WriteLine("Enter Password ");
                    user.Password = Console.ReadLine();
                    Console.WriteLine("Enter ContactDetails");
                    user.ContactDetails = Console.ReadLine();
                    Console.WriteLine("Enter Address ");
                    user.Address = Console.ReadLine();
                    Console.WriteLine("Enter city ");
                    user.City = Console.ReadLine();
                    Console.WriteLine("Enter state ");
                    user.State = Console.ReadLine();
                    Console.WriteLine("register successfully....................");
                    break;
                case 2:
                    Console.WriteLine("----------------login----------------- ");
                    Console.WriteLine("Enter the email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();

                    if (email == user.Email && password == user.Password)
                    {

                        Console.WriteLine("login successfull");
                        //if (user.UserRole == role.PublicUser)
                        //{
                            Console.WriteLine("nimmiiiiiiiiiiiii");
                            int userOption;
                            int loggedInUserId = -1;
                            do
                            {
                                Console.WriteLine("\nChoose an option:");
                                Console.WriteLine("1. Post a Pet");
                                Console.WriteLine("2. List Your Pets");
                                Console.WriteLine("3. Logout");
                                Console.Write("Enter your choice: ");
                                userOption = Convert.ToInt32(Console.ReadLine());


                                switch (userOption)
                                {
                                    case 1:
                                        if (petCount >= pets.Length)
                                        {
                                            Console.WriteLine("Pet limit reached.");
                                            break;
                                        }

                                        Pet newPet = new Pet();
                                        newPet.Id = petCount + 1;
                                        Console.Write("Enter Pet Name: ");
                                        newPet.Name = Console.ReadLine();
                                        Console.Write("Enter Pet Category: ");
                                        newPet.Category = Console.ReadLine();
                                        newPet.OwnerId = loggedInUserId;
                                        pets[petCount++] = newPet;
                                        Console.WriteLine("Pet posted successfully.");
                                        break;

                                    case 2:
                                        Console.WriteLine("\n--- Your Pets ---");
                                        bool hasPets = false;
                                        for (int j = 0; j < petCount; j++)
                                        {
                                            if (pets[j].OwnerId == loggedInUserId)
                                            {
                                                Console.WriteLine($"ID: {pets[j].Id}, Name: {pets[j].Name}, Category: {pets[j].Category}");
                                                hasPets = true;
                                            }
                                        }
                                        if (!hasPets)
                                        { 
                                            Console.WriteLine("You have not posted any pets.");
                                }
                                        break;




                                }

                            } while (userOption != 3);



                    }



                    //else
                    //    {
                    //        Console.WriteLine("not a publicuser");
                    //    }

                    //}

                    else
                    {
                        Console.WriteLine("Invalid email or password");
                    }

                    break;

            }




            } while (choice != 3) ;
        }

}
      

