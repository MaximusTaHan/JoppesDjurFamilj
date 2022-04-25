using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoppesDjurFamilj.Toys
{
    internal class TreatDispenserToy : Toy
    {
        public TreatDispenserToy(int treats) : base (treats)
        {
        }
        // Removes the number of treats eaten, if treats would be less than 0 it only returns whats left in the toy
        public int RemoveTreats(int number)
        {
            int check = quality - number;
            if(check < 0)
            {
                int treats = quality % number;
                quality = 0;
                //Modulus or remainder opperator. Returns the remaining treats in toy
                return treats;
            }

            return quality -= number;
        }

        //Fills dispenser with specified amount of treats
        public void Refill(int treats)
        {
            quality += treats;
            ToString();
        }

        public override string ToString()
        {
            return $"Treat dispenser. Treats remaining: {quality}";
        }
    }
}
