using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoppesDjurFamilj.Toys;

namespace JoppesDjurFamilj
{
    /// <summary>
    /// Animal class Defines base implementation of Animal. Is Abstract and should never be instantiated.
    /// </summary>
    public abstract class Animal
    {
        protected int age;
        protected string name;
        protected string faveFood;
        protected string breed;
        protected bool hungry = false;

        //Read only getter for name validation
        public string Name { get { return name; } }

        /// <summary>
        /// Base implementation of Interact method. Checks the parameter for its type and calls the apropriate method.
        /// If toy is a Ball and the pet is hungry it will call HungryAnimal, this prevents playing with a ball if pet is hungry.
        /// If toy is Ball it will call PlayWithBall
        /// If toy is a TreatDispenserToy it will call PlayWithDispenser
        /// </summary>
        /// <param name="toy">Toy from toys list</param>
        public virtual string Interact(Toy toy)
        {
            if (toy is Ball ball && hungry == true)
            {
                return HungryAnimal();
            }
            else if (toy is Ball ballCheck)
            {
                return PlayWithBall(ballCheck);
            }
            if (toy is TreatDispenserToy dispenserToy)
            {
                return PlayWithDispenser(dispenserToy);
            }
            return null;
        }

        // Sets hungry to false, can be overriden in derived classes for further extension or customisation
        /// <summary>
        /// Method call that sets pets hungry value to false.
        /// </summary>
        public string Eat()
        {
            hungry = false;
            return $"{name} chows down food vigorously... \"Chomp chomp chomp\"";
        }
        /// <summary>
        /// Defines behaviour for playing with dispenser. Calling RemoveTreats on the dispenser changes its quality field. 
        /// Will set pets hungry value to false.
        /// If the treats in the dispenser would run out it would only consume the available treats.
        /// </summary>
        /// <param name="dispenserToy">Specific toy from toys list</param>
        public virtual string PlayWithDispenser(TreatDispenserToy dispenserToy)
        {
            hungry = false;
            if (dispenserToy.Quality < 0)
            {
                dispenserToy.RemoveTreats(25);
                return $"{name} paws at the ball untill the last treat falls out. The toy seems to be empty";
            }
            dispenserToy.RemoveTreats(25);
            return $"{name} paws the treat ball around the floor untill it isnt as interesting anymore. 25 treats have been devoured";
        }

        /// <summary>
        /// Defines behaviour for playing with ball. Calling LowerQuality on the ball changes its quality field. 
        /// Will set pets hungry value to true.
        /// If the balls quality would be lower than 0 another message is displayed.
        /// </summary>
        /// <param name="ball">Specific toy from toys list</param>
        public virtual string PlayWithBall(Ball ball)
        {
            hungry = true;
            if (ball.Quality < 0)
            {
                ball.LowerQuality(30);
                return $"{name} chews ball into crumbles... What a mess. Should probably throw this one in the trash";
            }
            ball.LowerQuality(30);
            return $"{name} tosses and flails while the ball goes flying through the air";
        }
        /// <summary>
        /// Defines behaviour for animal when it is hungry, can be overriden to creat further customisation when interacting with derived classes
        /// </summary>
        public string HungryAnimal()
        {
            return $"{name} is too hungry to play, maybe it's time for dinner";
        }
        /// <summary>
        /// If the base implementation is called from the derived classes it will print the fields
        /// </summary>
        /// <returns>The various fields as a formatted string: "Name: {name}. Age: {age}. Favorite food: {faveFood}. Breed: {breed}. Hungry: {hungry}"</returns>
        public override string ToString()
        {
            return $"Name: {name}. Age: {age}. Favorite food: {faveFood}. Breed: {breed}. Hungry: {hungry}";
        }
    }
}
