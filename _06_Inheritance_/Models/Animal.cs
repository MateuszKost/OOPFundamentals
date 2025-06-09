namespace _06_Inheritance_.Models;

/// <summary>
/// Base class representing a generic Animal.
/// Contains shared properties and behavior.
/// </summary>
public class Animal
{
    private int Age { get; }
    protected string Name { get; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Describe()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }

    /// <summary>
    /// Virtual method to be overridden by derived classes.
    /// </summary>
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a generic animal sound.");
    }
}
