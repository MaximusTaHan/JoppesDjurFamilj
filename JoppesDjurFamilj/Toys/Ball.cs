using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoppesDjurFamilj.Toys
{
    internal class Ball : Toy
    {
        private string color;

        public Ball(string setColor, int setQuality) : base (setQuality)
        {
            color = setColor;
        }

        /// <summary>
        /// Takes in the damage done to the ball and subtracts it from quality. Returns the remaining quality of the ball to check if its still usable
        /// </summary>
        /// <param name="damage">Amount of damage to subtract from quality</param>
        /// <returns>Quality value of ball</returns>
        public int LowerQuality(int damage)
        {
            return quality -= damage;
        }
        //For checking toys
        /// <summary>
        /// Prints string of toy with fields values
        /// </summary>
        /// <returns>The various fields as a formatted string: "Ball. Color: {color}. Quality: {quality}"</returns>
        public override string ToString()
        {
            return $"Ball. Color: {color}. Quality: {quality}";
        }
    }
}
