using _02_Abstract_vs_Interface_vs_Virtual_.Interfaces;

namespace _02_Abstract_vs_Interface_vs_Virtual_.Models;

/// <summary>
/// Bird class inherits from Animal and implements IFlyable interface.
/// Must implement MakeSound() and Fly().
/// </summary>
public class Bird : Animal, IFlyable
{
    public Bird(string name) : base(name) { }

    /// <summary>
    /// Bird's implementation of MakeSound() method.
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine("Tweet!");
    }

    /// <summary>
    /// Fly method required by IFlyable interface.
    /// </summary>
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying high!");
    }
}