using _06_Inheritance_.Models;

namespace _06_Inheritance_;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Inheritance Example ===\n");

        Animal dog = new Dog("Burek", 4);
        dog.Describe();
        dog.MakeSound();

        Console.WriteLine();

        Animal cat = new Cat("Mila", 3);
        cat.Describe();
        cat.MakeSound();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}