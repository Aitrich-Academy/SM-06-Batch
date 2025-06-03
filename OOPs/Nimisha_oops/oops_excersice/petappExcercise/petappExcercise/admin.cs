using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petappExcercise
{
    internal class admin
    {
        private Usercs[] users = new Usercs[2];
        private int num_users = 0;
        
        Petmanager pet = new Petmanager();
        bool _isLogged = false;
        public void Register(string username, string password)
        {
            if (num_users == users.Length)
            {
                Console.WriteLine("Maximum number of users reached. Please try again later.");
                return;
            }

            // Check if username is already taken


            Usercs newUser = new Usercs(username, password);
            users[num_users] = newUser;
            num_users++;

            Console.WriteLine("Registration successful.");
        }

        public bool Login(string username, string password)
        {
            for (int i = 0; i < num_users; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    Console.WriteLine("Login successful!");
                    _isLogged = true;
                    string ch = "0";
                    if (_isLogged)

                        while (ch != "6")
                        {
                            Console.WriteLine("1 .post pet\n");
                            Console.WriteLine("2.List pet\n");
                            Console.WriteLine("3.favourite  pet\n");
                            Console.WriteLine("4.remove  pet\n");
                                Console.WriteLine("5.List pet\n");
                            Console.WriteLine("6.Back to main menu\n");
                            ch = Console.ReadLine();

                            if (ch == "1")
                            {
                                pet.addpet();

                            }
                            if (ch == "2")
                            {
                                pet.Listpet();
                            }
                            if (ch == "3")
                            {
                                pet.SetFavoritePet();
                            }
                            if (ch == "4")
                            {
                                pet.RemoveFromFavorites();
                            }
                            if (ch == "5")
                            {
                                pet.Listpet();
                            }
                            if (ch == "6")
                            {
                                Console.Write("exit");
                            }
                        }
                    return true;
                }
            }

            Console.WriteLine("Invalid username or password.");
            return false;
        }


    }
}

