using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverload
{
    public class PetSeller
    {
        private string _sellername;
        private Pet _pet;

        public PetSeller(string sellername,Pet pet)
        {
            _sellername = sellername;
            _pet = pet;
        }
        public void SellPet()
        {
            Console.WriteLine($"{_sellername}is selling");
            _pet.DisplayInfo();
        }
    }
}
