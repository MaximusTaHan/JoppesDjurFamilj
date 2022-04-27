using JoppesDjurFamilj;
using JoppesDjurFamilj.Toys;

internal class PetOwner
{
    private int age = 30;
    private List<Animal> animals = new();
    private List<Toy> toys = new();
    // Pets for owner 
    Puppy puppy = new(0, 11, "Scrappy", "Great-dane");
    Dog dog = new(5, "Scooby", "Great-dane");
    Cat cat = new(6, "Garfield", "Persian", "Lasagna");

    //Toys for owner
    Ball ball = new("Red", 100);
    TreatDispenserToy treatDispenser = new(100);

    /// <summary>
    /// Prints the main menu options for the App and validates the user input against a Switch/Case for where to go.
    /// Also adds the preset pets/toys to the animals/toys list. 
    /// </summary>
    internal void Menu()
    {
        AddPets();
        AddToys();

        while(true)
        {
            Console.Clear();
            Console.WriteLine("\n\nWelcome to Joppes Animal family");
            Console.WriteLine("\n\nWhat would you like to do?");
            Console.WriteLine("\nMain Menu");

            Console.WriteLine("\nPress 0 to exit the application");
            Console.WriteLine("Press 1 to Interact with an Animal");
            Console.WriteLine("Press 2 to Get a new Toy");
            Console.WriteLine("Press 3 to Check out all Animals");
            Console.WriteLine("Press 4 to Check out your Toys");
            Console.Write("Choice: ");

            var input = Console.ReadLine();

            switch(input)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    InitializeInteract();
                    break;
                case "2":
                    ToyOptions();
                    break;
                case "3":
                    ViewAnimals();
                    break;
                case "4":
                    ViewToys();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }
        }
    }

    /// <summary>
    /// Prints the options for toys. Validates user input against toy options.
    /// If 1 is chosen the method will prompt the user for a color (The input is not validated).
    /// If 2 is chosen the method will prompt the user for an amount to refill the dispenser.
    /// </summary>
    private void ToyOptions()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press 1 to get a new Ball");
        Console.WriteLine("Press 2 to Refill treats");

        var input = Console.ReadLine();

        while (input != "1" && input != "2")
        {
            Console.WriteLine("\nNot a valid input");
            Console.Write("Try again: ");
            input = Console.ReadLine();
        }

        if(input == "1")
        {
            Console.WriteLine("Order a new ball online with instant Dellivery");
            Console.Write("Color: ");
            var color = Console.ReadLine();

            Ball newBall = new(color, 100);
            toys.Add(newBall);
        }
        if(input == "2")
        {
            int amount;
            //Finds object in list of TreatDispenseToy type or default
            var dispenser = toys.OfType<TreatDispenserToy>().FirstOrDefault();

            Console.WriteLine("How many treats do you want to insert?");
            Console.Write("Treats: ");

            var treatInput = Console.ReadLine();

            while(!int.TryParse(treatInput, out amount))
            {
                Console.WriteLine("Please input a valid number");
                Console.Write("Try again: ");
                treatInput = Console.ReadLine();
            }

            dispenser.Refill(amount);
        }
    }

    /// <summary>
    /// Picks out the animal from the list of animals by finding the Name getter that matches the user input.
    /// Then it calls the PetOptions method with the chosen Pet as argument.
    /// </summary>
    private void InitializeInteract()
    {
        Console.Clear();

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }

        Console.WriteLine("\n\nWhich pet would you like to interact with?");
        Console.Write("\nPet name: ");
        var input = Console.ReadLine();

        var pet = animals.Find(animal => animal.Name == input);
        while(pet == null)
        {
            Console.WriteLine("\nPlease enter a valid Pet name");
            Console.Write("\nPet name: ");
            input = Console.ReadLine();
            pet = animals.Find(animal => animal.Name == input);
        }

        PetOptions(pet);
    }

    /// <summary>
    /// Prints options for interactions and validates the user input
    /// </summary>
    /// <param name="pet">The animal from animals list</param>
    private void PetOptions(Animal pet)
    {
        Console.Clear();
        Console.WriteLine($"\n\nWhat would you like to do with {pet.Name}?");
        Console.WriteLine("Press 0 to return to Menu");
        Console.WriteLine("Press 1 to Play");
        Console.WriteLine("Press 2 to Feed");
        Console.Write("\nOption: ");

        var input = Console.ReadLine();

        if (input == "0")
            return;

        while(input != "1" && input != "2")
        {
            Console.WriteLine("\nNot a valid input");
            Console.Write("Try again: ");
            input = Console.ReadLine();
        }

        if (input == "1")
        {
            play(pet);
        }
        if(input == "2")
        {
            pet.Eat();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }

    /// <summary>
    /// Prints toys and lets user choose which one to use. If the toy is broken or empty, it will not let you continue
    /// Then it will call the interact method with chosen toy.
    /// If the chosen toys quality value is below 0 it will prevent using that toy.
    /// </summary>
    /// <param name="pet">The animal from animals list</param>
    private void play(Animal pet)
    {
        int num = 0;

        Console.Clear();
        Console.WriteLine("\n\n");
        foreach (Toy toy in toys)
        {
            Console.WriteLine($"Toy {num}: " + toy.ToString());
            num++;
        }

        Console.WriteLine("\nChoose a toy");
        Console.WriteLine("Type \"Exit\" to return to Menu");
        Console.Write("Toy number: ");
        var choosenInput = Console.ReadLine();

        if (choosenInput == "Exit")
            return;

        int temp;

        while (!int.TryParse(choosenInput, out temp) || toys[temp].Quality <= 0)
        {
            Console.WriteLine("Not a valid toy");
            Console.WriteLine("Try again: ");
            choosenInput = Console.ReadLine();
            if (choosenInput == "Exit")
                return;
        }

        pet.Interact(toys[temp]);
    }

    /// <summary>
    /// Prints toys in list and waits for key press
    /// </summary>
    private void ViewToys()
    {
        Console.WriteLine("\n\n");
        foreach(var toy in toys)
        {
            Console.WriteLine(toy.ToString());
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
    /// <summary>
    /// Prints pets in list and waits for key press
    /// </summary>
    private void ViewAnimals()
    {
        Console.WriteLine("\n\n");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
    /// <summary>
    /// Adds preset Toys to toys list
    /// </summary>
    private void AddToys()
    {
        toys.Add(ball);
        toys.Add(treatDispenser);
    }

    /// <summary>
    /// Adds preset Animals to animals list
    /// </summary>
    private void AddPets()
    {
        animals.Add(dog);
        animals.Add(puppy);
        animals.Add(cat);
    }
}