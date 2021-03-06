using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoppesDjurFamilj.Toys
{
    public class TreatDispenserToy : Toy
    {
        public TreatDispenserToy(int treats) : base (treats)
        {
        }
        /// <summary>
        /// Removes the number of treats eaten, if treats would be less than 0 it only returns whats left in the toy
        /// </summary>
        /// <param name="number">Number of treats to remove</param>
        /// <returns>Number of treats left</returns>
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
        /// <summary>
        /// Refills the dispenser by adding to the quality field
        /// </summary>
        /// <param name="treats">Amount to add to quality field</param>
        public void Refill(int treats)
        {
            quality += treats;
            ToString();
        }
        /// <summary>
        /// Prints string of toy with fields values
        /// </summary>
        /// <returns>The various fields as a formatted string: "Treat dispenser. Treats remaining: {quality}"</returns>
        public override string ToString()
        {
            return $"Treat dispenser. Treats remaining: {quality}";
        }
    }
}
