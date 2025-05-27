namespace _01_OOP_Intro_.Procedural;

/// <summary>
/// This class demonstrates a procedural approach to managing animals,
/// without using classes or objects.
/// It uses separate lists and functions to simulate animal data and behavior.
/// </summary>
public static class ProceduralAnimalShelter
{
    /// <summary>
    /// Entry method to run the procedural example.
    /// Prints animal info and makes each animal "speak" based on its type.
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("=== Procedural Version ===\n");

        // Separate lists holding animal data by parallel indexes
        List<string> names = new() { "Burek", "Mila" };
        List<string> types = new() { "Dog", "Cat" };
        List<int> ages = new() { 5, 3 };

        // Loop through the lists by index to display info and simulate behavior
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"Animal - {types[i]}: {names[i]}, {ages[i]} years old");
            MakeSound(types[i], names[i]);  // Call method to print animal sound
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Prints the sound an animal makes, based on its type.
    /// This is a procedural alternative to polymorphism.
    /// </summary>
    /// <param name="type">Type of the animal (e.g. "Dog", "Cat")</param>
    /// <param name="name">Name of the animal</param>
    static void MakeSound(string type, string name)
    {
        if (type == "Dog")
        {
            Console.WriteLine($"{name} says: Woof!");
        }
        else if (type == "Cat")
        {
            Console.WriteLine($"{name} says: Meow!");
        }
        else
        {
            Console.WriteLine($"{name} makes an unknown sound.");
        }
    }
}