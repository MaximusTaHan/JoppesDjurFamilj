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

        //Takes in the damage done to the ball and subtracts it from quality. Returns the remaining quality of the ball to check if its still usable
        public int LowerQuality(int damage)
        {
            return quality -= damage;
        }
        //For checking toys
        public override string ToString()
        {
            return $"Ball. Color: {color}. Quality: {quality}";
        }
    }
}
