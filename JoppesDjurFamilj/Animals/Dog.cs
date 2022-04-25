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
        // Constructor that sets name, age and breed. All dogs love Scooby-snacks so that field is set on initialization
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
