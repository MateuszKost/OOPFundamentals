namespace _06_Inheritance_.Models;

/// <summary>
/// Cat inherits from Animal and overrides MakeSound.
/// </summary>
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}
