using _05_Constructors_And_Overloading_.Models;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Constructors and Overloading ===\n");

        var p1 = new Person(); // Default
        p1.ShowInformation();

        Console.WriteLine();

        var p2 = new Person("Alice"); // One param
        p2.ShowInformation();

        Console.WriteLine();

        var p3 = new Person("Bob", 30); // Two params
        p3.ShowInformation();

        Console.WriteLine();

        var p4 = new Person("Charlie", 25, "USA"); // Full constructor
        p4.ShowInformation();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}