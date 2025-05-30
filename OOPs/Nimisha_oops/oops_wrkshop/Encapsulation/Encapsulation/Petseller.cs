using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Petseller
    {
        private Pet[] petsforsale;
        public Petseller(Pet[] petsforsale)
        

            {
                this.petsforsale = petsforsale;
            }
        public void DisplayAvaliablePets()
        {
            Console.WriteLine("pets aavaliable for sale");
            foreach (Pet pet in petsforsale)
            {
                pet.Displayinfo();   
            }
        }
            
        }
}

