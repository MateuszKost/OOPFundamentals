namespace _01_OOP_Intro_.OOP;

/// <summary>
/// Represents a Cat with basic properties and behaviors.
/// </summary>
public class Cat
{
    // Properties to store cat's name and age
    public string Name { get; set; }
    public int Age { get; set; }
        
    // Constructor to initialize a Cat object
    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to print a description of the cat
    public void Describe()
    {
        Console.WriteLine($"Cat - {Name}, {Age} years old");
    }
        
    // Method to simulate the cat making a sound
    public void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}