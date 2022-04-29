using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoppesDjurFamilj.Toys;

namespace JoppesDjurFamilj
{
    internal class Cat : Animal
    {
        // Constructor for cat, can set the favoriteFood since cats are picky eaters
        public Cat(int setAge, string setName, string setBreed, string favoriteFood)
        {
            age = setAge;
            name = setName;
            breed = setBreed;
            faveFood = favoriteFood;
        }

        /// <summary>
        /// Checks if toy is ball or dispenser, if toy is a ball and the Cat is hungry it will go out to hunt. If its a treat dispenser it will "play" with it instead of hunting
        /// If toy is a Ball and the pet is hungry it will call HungryAnimal, this prevents playing with a ball if pet is hungry.
        /// If toy is Ball it will call PlayWithBall
        /// If toy is a TreatDispenserToy it will call PlayWithDispenser
        /// </summary>
        /// <param name="toy">Specific toy from toys list</param>
        public override string Interact(Toy toy)
        {
            if (toy is Ball ball && hungry == true)
            {
                hungry = false;
                return $"{name} seems dissintrested in playing and waddeles out the cat door. Probably to go hunt for a snack";
            }
            else if(toy is Ball ballCheck)
            {
                return PlayWithBall(ballCheck);
            }
            if (toy is TreatDispenserToy dispenserToy)
            {
                return PlayWithDispenser(dispenserToy);
            }
            return "";
        }
        /// <summary>
        /// Defines behaviour for playing with dispenser. Calling RemoveTreats on the dispenser changes its quality field. 
        /// Will set pets hungry value to false.
        /// If the treats in the dispenser would run out it would only consume the available treats.
        /// </summary>
        /// <param name="dispenserToy">Specific toy from toys list</param>
        public override string PlayWithDispenser(TreatDispenserToy dispenserToy)
        {
            hungry = false;
            if (dispenserToy.Quality < 0)
            {
                dispenserToy.RemoveTreats(15);
                return $"{name} reaches inside and scoops out the few Treats left. The toy seems to be empty";
            }
            if (dispenserToy.Quality > 0)
            {
                dispenserToy.RemoveTreats(15);
                return $"{name} intermittently swats the treat ball around untill pieces of treats fall out. About 15 treats have been crunched up";
            }
            return "";
        }

        /// <summary>
        /// Defines behaviour for playing with ball. Calling LowerQuality on the ball changes its quality field. 
        /// Will set pets hungry value to true.
        /// If the balls quality would be lower than 0 another message is displayed.
        /// </summary>
        /// <param name="ball">Ball from toys list</param>
        public override string PlayWithBall(Ball ball)
        {
            hungry = true;
            if (ball.Quality < 0)
            {
                ball.LowerQuality(10);
                return $"{name} holds the ball and kicks it into pieces... Like cats do. Should probably throw this one in the trash";
            }
            ball.LowerQuality(10);
            return $"{name} tosses and flails while the ball goes flying through the air";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
