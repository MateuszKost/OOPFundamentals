namespace _02_Abstract_vs_Interface_vs_Virtual_.Models;

/// <summary>
/// Abstract base class representing an Animal.
/// Cannot be instantiated directly.
/// Defines abstract and virtual methods to be used by subclasses.
/// </summary>
public abstract class Animal
{
    // Property accessible from derived classes and outside
    public string Name { get; set; }

    // Constructor initializes the name
    public Animal(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Abstract method that derived classes MUST implement.
    /// Represents the sound an animal makes.
    /// </summary>
    public abstract void MakeSound();

    /// <summary>
    /// Virtual method with default implementation.
    /// Can be overridden by subclasses for custom behavior.
    /// </summary>
    public virtual void Describe()
    {
        Console.WriteLine($"This is an animal named {Name}.");
    }
}