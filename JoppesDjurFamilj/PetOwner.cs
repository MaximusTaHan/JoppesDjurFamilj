using JoppesDjurFamilj;
using JoppesDjurFamilj.Toys;
/// <summary>
/// PetOwner defines behaviour for pet options
/// </summary>
public class PetOwner
{
    private int age = 30;
    public List<Animal> animals = new();
    private List<Toy> toys = new();

    // Pets for owner 
    Puppy puppy = new(0, 11, "Scrappy", "Great-dane");
    Dog dog = new(5, "Scooby", "Great-dane");
    Cat cat = new(6, "Garfield", "Persian", "Lasagna");

    //Toys for owner
    Ball ball = new("Red", 100);
    TreatDispenserToy treatDispenser = new(100);

    /// <summary>
    /// Adds pets/toys to lists on construction
    /// </summary>
    public PetOwner()
    {
        AddPets();
        AddToys();
    }

    /// <summary>
    /// Finds apropriate dispenser Toy in list and calls Refill method with amount specified by parameter
    /// </summary>
    /// <param name="amount">User input from Input textbox, parsed to Int</param>
    public void Refill(int amount)
    {
        //Finds object in list of TreatDispenseToy type or default
        var dispenser = toys.OfType<TreatDispenserToy>().FirstOrDefault();

        dispenser.Refill(amount);
    }

    /// <summary>
    /// Instantiates a new Ball object with user input as color
    /// </summary>
    /// <param name="color">User input from Input textbox</param>
    public void MakeBall(string color)
    {
        Ball newBall = new(color, 100);
        toys.Add(newBall);
    }

    /// <summary>
    /// Picks out the animal from the list of animals by finding the Name getter that matches the user input.
    /// </summary>
    /// <param name="name">User input from Input textbox</param>
    /// <returns>Animal object that matches the input name</returns>
    public Animal InitializeInteract(string name)
    {

        var pet = animals.Find(animal => animal.Name == name);

        return pet;
    }

    /// <summary>
    /// Sets the current Toy object for use in several event listeners
    /// </summary>
    /// <param name="num">User input value to search Toy list</param>
    /// <returns>Toy object from toys list that matches user input index</returns>
    public Toy SetCurrentToy(int num)
    {
        Toy toy;
        try
        {
            toy = toys[num];
        }
        catch (Exception ex)
        {
            return null;
        }

        return toy;
    }

    /// <summary>
    /// Prints toys in list and waits for key press
    /// </summary>
    public List<Toy> ViewToys()
    {
        return toys;
    }
    /// <summary>
    /// Prints pets in list and waits for key press
    /// </summary>
    public List<Animal> ViewAnimals()
    {
        return animals;
    }
    /// <summary>
    /// Adds preset Toys to toys list
    /// </summary>
    public void AddToys()
    {
        toys.Add(ball);
        toys.Add(treatDispenser);
    }

    /// <summary>
    /// Adds preset Animals to animals list
    /// </summary>
    public void AddPets()
    {
        animals.Add(dog);
        animals.Add(puppy);
        animals.Add(cat);
    }
}