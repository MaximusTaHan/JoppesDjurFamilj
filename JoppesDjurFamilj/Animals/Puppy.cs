using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoppesDjurFamilj.Toys;

namespace JoppesDjurFamilj
{
    internal class Puppy : Dog
    {
        private int months;
        //Calls the Dogs constructor in the Puppy class. This sets fave food to Scooby-snacks through Dog Constructor
        public Puppy (int setAge, int months, string name, string breed) : base (setAge, name, breed)
        {
            setAge = 0;
            this.months = months;
            this.name = name;
            this.breed = breed;
        }

        public override void Interact(Toy toy)
        {
            if (toy is Ball ball && hungry == true)
            {
                HungryAnimal();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
            else if (toy is Ball ballCheck)
            {
                PlayWithBall(ballCheck);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
            if (toy is TreatDispenserToy dispenserToy)
            {
                PlayWithDispenser(dispenserToy);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        private void PlayWithDispenser(TreatDispenserToy dispenserToy)
        {
            hungry = false;
            if (dispenserToy.Quality < 0)
            {
                Console.WriteLine($"{name} paws at the ball untill the last treat falls out. The toy seems to be empty");
                dispenserToy.RemoveTreats(10);
                return;
            }
            Console.WriteLine($"{name} paws the treat ball around the floor but gets bored quickly. 10 treats was the limit before boredom sets in");
            dispenserToy.RemoveTreats(10);
        }

        //Defines behaviour for playing with ball. Calling LowerQuality on the ball
        private void PlayWithBall(Ball ball)
        {
            hungry = true;
            if (ball.Quality < 0)
            {
                ball.LowerQuality(10);
                Console.WriteLine($"{name} knaws the ball to pieces... Puppy teeth has to be itchy. Should probably throw this one in the trash");
                return;
            }
            Console.WriteLine($"{name} tumbles around with the ball, it's hard to tell which one is doing more tumbles");
            ball.LowerQuality(10);
        }
        public override string ToString()
        {
            return $"Name: {name}. Age: {months} (months). Favorite food: {faveFood}. Breed: {breed}. Hungry: {hungry}";
        }
    }
}
