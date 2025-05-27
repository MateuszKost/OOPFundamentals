namespace _02_Abstract_vs_Interface_vs_Virtual_.Models;

/// <summary>
/// Cat class inherits from Animal.
/// Implements MakeSound() and optionally overrides Describe().
/// </summary>
public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    // No override of Describe() here — uses default implementation from Animal.
}