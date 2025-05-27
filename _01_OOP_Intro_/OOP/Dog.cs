namespace _01_OOP_Intro_.OOP;

/// <summary>
/// Represents a Dog with basic properties and behaviors.
/// </summary>
public class Dog
{
    // Properties to store dog's name and age
    public string Name { get; set; }
    public int Age { get; set; }
        
    // Constructor to initialize a Dog object
    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to print a description of the dog
    public void Describe()
    {
        Console.WriteLine($"Dog - {Name}, {Age} years old");
    }

    // Method to simulate the dog making a sound
    public void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}