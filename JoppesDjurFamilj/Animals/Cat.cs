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

        // Checks if toy is ball or dispenser, if toy is a ball and the Cat is hungry it will go out to hunt. If its a treat dispenser it will "play" with it instead of hunting
        public override void Interact(Toy toy)
        {
            if (toy is Ball ball && hungry == true)
            {
                Console.WriteLine($"{name} seems dissintrested in playing and waddeles out the cat door. Probably to go hunt for a snack");
                hungry = false;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
            else if(toy is Ball ballCheck)
            {
                PlayWithBall(ballCheck);
            }
            if (toy is TreatDispenserToy dispenserToy)
            {
                PlayWithDispenser(dispenserToy);
            }
        }
        // Defines behaviour for dispenser toy depending on how many treats it holds
        private void PlayWithDispenser(TreatDispenserToy dispenserToy)
        {
            hungry = false;
            if (dispenserToy.Quality < 0)
            {
                Console.WriteLine($"{name} reaches inside and scoops out the few Treats left. The toy seems to be empty");
                dispenserToy.RemoveTreats(15);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return;
            }
            if (dispenserToy.Quality > 0)
            {
                Console.WriteLine($"{name} intermittently swats the treat ball around untill pieces of treats fall out. About 15 treats have been crunched up");
                dispenserToy.RemoveTreats(15);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return;
            }
        }

        //Defines behaviour for playing with ball. Calling LowerQuality on the ball
        private void PlayWithBall(Ball ball)
        {
            hungry = true;
            if (ball.Quality < 0)
            {
                ball.LowerQuality(10);
                Console.WriteLine($"{name} holds the ball and kicks it into pieces... Like cats do. Should probably throw this one in the trash");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return;
            }
            Console.WriteLine($"{name} tosses and flails while the ball goes flying through the air");
            ball.LowerQuality(10);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
