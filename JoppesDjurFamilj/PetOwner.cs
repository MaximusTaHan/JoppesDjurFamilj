using JoppesDjurFamilj;
using JoppesDjurFamilj.Toys;

internal class PetOwner
{
    private int age = 30;
    private List<Animal> animals = new();
    private List<Toy> toys = new();
    // pets for owner 
    Puppy puppy = new(0, 11, "Scrappy", "Great-dane");
    Dog dog = new(5, "Scooby", "Great-dane");
    Cat cat = new(6, "Garfield", "Persian", "Lasagna");

    //toys for owner
    Ball ball = new("Red", 100);
    TreatDispenserToy treatDispenser = new(100);
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
            //Finds object in list of TreatDispenseToy type or default
            var dispenser = toys.OfType<TreatDispenserToy>().FirstOrDefault();
            Console.WriteLine("How many treats do you want to insert?");
            Console.Write("Treats: ");
            var treatInput = Console.ReadLine();
            int amount;
            while(!int.TryParse(treatInput, out amount))
            {
                Console.WriteLine("Please input a valid number");
                Console.Write("Try again: ");
                treatInput = Console.ReadLine();
            }

            dispenser.Refill(amount);
        }
    }

    //picks out the animal from the list of animals by finding the name getter that matches the input
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

    //Prints options for interactions and validates the user input
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
    //  Prints toys and lets user choose which one to use. If the toy is broken or empty, it will not let you continue
    //  Then it will call the interact method with chosen toy
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

        while (!int.TryParse(choosenInput, out temp) || toys[temp].Quality < 0)
        {
            Console.WriteLine("Not a valid toy");
            Console.WriteLine("Try again: ");
            choosenInput = Console.ReadLine();
            if (choosenInput == "Exit")
                return;
        }

        pet.Interact(toys[temp]);
    }

    // View pets in list and wait for key press
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
    // View pets in list and wait for key press
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
    // Adds toys to list
    private void AddToys()
    {
        toys.Add(ball);
        toys.Add(treatDispenser);
    }

    //Adds animals to list 
    private void AddPets()
    {
        animals.Add(dog);
        animals.Add(puppy);
        animals.Add(cat);
    }
}