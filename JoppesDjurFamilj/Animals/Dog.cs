using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoppesDjurFamilj.Toys;

namespace JoppesDjurFamilj
{
    internal class Dog : Animal
    {
        /// <summary>
        /// Constructor that sets name, age and breed. All dogs love Scooby-snacks so that field is set on initialization
        /// </summary>
        /// <param name="setAge">Int age of Dog</param>
        /// <param name="setName">String name of Dog</param>
        /// <param name="setBreed">String breed of Dog</param>
        public Dog(int setAge, string setName, string setBreed)
        {
            name = setName;
            age = setAge;
            breed = setBreed;
            faveFood = "Scooby-snacks";
        }

        // Calls base class implementation of ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
