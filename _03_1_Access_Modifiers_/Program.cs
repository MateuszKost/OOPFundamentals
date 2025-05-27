using _03_2_Access_Modifiers_.Models;

namespace _03_1_Access_Modifiers_;

public static class Program
{
    public static void Main()
    {
        var person = new Person("Alice", 30);
        Console.WriteLine($"Person's name: {person.Name}");  // public - accessible everywhere

        // Can't access private member _age directly:
        // Console.WriteLine(person._age); // Error! _age is private to Person class

        // Access age via public method (allowed)
        Console.WriteLine($"Person's age: {person.GetAge()}"); 

        var employee = new Employee("Bob", 28);
        employee.ShowInfo(); // Shows all accessible members within Employee (derived class)

        // Trying to access internal property from a different project/assembly would cause error
        // But if this is the same assembly, it's accessible here.
        // Console.WriteLine(employee.InternalCode); // This is internal; accessible only within same assembly

        // Example:
        // 'InternalCode' is accessible here only if Program and Models are in the same assembly/project.
        // If they're separated into different assemblies, this line will cause a compilation error.

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

}