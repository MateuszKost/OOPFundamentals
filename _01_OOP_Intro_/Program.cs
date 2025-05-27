using _01_OOP_Intro_.OOP;
using _01_OOP_Intro_.Procedural;

namespace _01_OOP_Intro_;

/// <summary>
/// Entry point of the application.
/// Demonstrates the difference between procedural and object-oriented approaches.
/// </summary>
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== OOP vs Procedural ===\n");

        // Run the procedural example — uses separate lists and functions
        ProceduralAnimalShelter.Run();

        // Separator for clarity
        Console.WriteLine("=== Object-Oriented Version ===\n");

        // Create Dog object and demonstrate its behavior
        var dog = new Dog("Burek", 5);
        dog.Describe();
        dog.MakeSound();

        Console.WriteLine();

        // Create Cat object and demonstrate its behavior
        var cat = new Cat("Mila", 3);
        cat.Describe();
        cat.MakeSound();
    }
}