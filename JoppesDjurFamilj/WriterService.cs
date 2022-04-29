using JoppesDjurFamilj;

internal class WriterService
{
    private List<Animal> animals;
    // Sets environment path to MyDocuments
    private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    // Constructor takes in list of animals
    public WriterService(List<Animal> animals)
    {
        this.animals = animals;
    }

    internal void WriteAnimals()
    {
        // Dont need braces on using statement, using statement will close the streamwriter upon leaving the scope
        using StreamWriter documentFile = new(Path.Combine(path, "JoppesAnimals.txt"));

        foreach (Animal animal in animals)
            documentFile.WriteLine(animal.ToString());
    }
}