namespace _06_Inheritance_.Models;

/// <summary>
/// Dog inherits from Animal and overrides MakeSound.
/// </summary>
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}
