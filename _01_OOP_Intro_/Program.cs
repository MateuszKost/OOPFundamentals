using _01_OOP_Intro_.OOP;
using _01_OOP_Intro_.Procedural;

namespace _01_OOP_Intro_;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== OOP vs Procedural ===\n");

        // Procedural approach
        ProceduralAnimalShelter.Run();

        // OOP approach
        Console.WriteLine("=== Object-Oriented Version ===\n");

        List<Animal> animals = new List<Animal>
        {
            new Dog("Burek", 5),
            new Cat("Mila", 3)
        };

        foreach (var animal in animals)
        {
            animal.Describe();
            animal.MakeSound();
            Console.WriteLine();
        }
    }
}