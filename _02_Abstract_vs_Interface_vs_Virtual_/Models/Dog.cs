namespace _02_Abstract_vs_Interface_vs_Virtual_.Models;

/// <summary>
/// Dog class inherits from Animal.
/// Implements abstract MakeSound() and overrides Describe().
/// </summary>
public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    /// <summary>
    /// Implementation of the abstract method.
    /// Dogs bark "Woof!"
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    /// <summary>
    /// Overrides the virtual Describe() method.
    /// Provides more specific description for Dog.
    /// </summary>
    public override void Describe()
    {
        Console.WriteLine($"Dog named {Name}, loyal and friendly.");
    }
}
