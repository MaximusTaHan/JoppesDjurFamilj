using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoppesDjurFamilj.Toys;

namespace JoppesDjurFamilj
{
    internal abstract class Animal
    {
        protected int age;
        protected string name;
        protected string faveFood;
        protected string breed;
        protected bool hungry = false;

        //Read only getter for name validation
        public string Name { get { return name; } }

        //Abstract class should never be instantiated, method implementation is defined in derived classes
        public virtual void Interact(Toy toy)
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

        // Sets hungry to false, can be overriden in derived classes for further extension or customisation
        public virtual void Eat()
        {
            hungry = false;
            Console.WriteLine($"{name} chows down food vigorously... \"Chomp chomp chomp\"");
        }
        private void PlayWithDispenser(TreatDispenserToy dispenserToy)
        {
            hungry = false;
            if (dispenserToy.Quality < 0)
            {
                Console.WriteLine($"{name} paws at the ball untill the last treat falls out. The toy seems to be empty");
                dispenserToy.RemoveTreats(25);
                return;
            }
            Console.WriteLine($"{name} paws the treat ball around the floor untill it isnt as interesting anymore. 25 treats have been devoured");
            dispenserToy.RemoveTreats(25);
        }

        //Defines behaviour for playing with ball. Calling LowerQuality on the ball
        private void PlayWithBall(Ball ball)
        {
            hungry = true;
            if (ball.Quality < 0)
            {
                ball.LowerQuality(30);
                Console.WriteLine($"{name} chews ball into crumbles... What a mess. Should probably throw this one in the trash");
                return;
            }
            Console.WriteLine($"{name} tosses and flails while the ball goes flying through the air");
            ball.LowerQuality(30);
        }
        // Defines behaviour for animal when it is hungry, can be overriden to creat further customisation when interacting with derived classes
        public void HungryAnimal()
        {
            Console.WriteLine($"{name} is too hungry to play, maybe it's time for dinner");
        }
        //If the base implementation is called from the derived classes it will print the fields
        public override string ToString()
        {
            return $"Name: {name}. Age: {age}. Favorite food: {faveFood}. Breed: {breed}. Hungry: {hungry}";
        }
    }
}
