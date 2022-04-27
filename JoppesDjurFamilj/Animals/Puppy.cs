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
        /// <summary>
        /// Defines behaviour for playing with dispenser. Calling RemoveTreats on the dispenser changes its quality field. 
        /// Will set pets hungry value to false.
        /// If the treats in the dispenser would run out it would only consume the available treats.
        /// </summary>
        /// <param name="dispenserToy">Specific toy from toys list</param>
        public override void PlayWithDispenser(TreatDispenserToy dispenserToy)
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

        /// <summary>
        /// Defines behaviour for playing with ball. Calling LowerQuality on the ball changes its quality field. 
        /// Will set pets hungry value to true.
        /// If the balls quality would be lower than 0 another message is displayed.
        /// </summary>
        /// <param name="ball">Ball from toys list</param>
        public override void PlayWithBall(Ball ball)
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
        /// <summary>
        /// Prints string of puppy with fields values. This iplementation prints Age as a months specific value
        /// </summary>
        /// <returns>The various fields as a formatted string: "Name: {name}. Age: {months} (months). Favorite food: {faveFood}. Breed: {breed}. Hungry: {hungry}"</returns>
        public override string ToString()
        {
            return $"Name: {name}. Age: {months} (months). Favorite food: {faveFood}. Breed: {breed}. Hungry: {hungry}";
        }
    }
}
