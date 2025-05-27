namespace _01_OOP_Intro_.Procedural;

public static class ProceduralAnimalShelter
{
    public static void Run()
    {
        Console.WriteLine("=== Procedural Version ===\n");

        List<string> names = new() { "Burek", "Mila" };
        List<string> types = new() { "Dog", "Cat" };
        List<int> ages = new() { 5, 3 };

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"Animal - {types[i]}: {names[i]}, {ages[i]} years old");
            MakeSound(types[i], names[i]);
            Console.WriteLine();
        }
    }

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
