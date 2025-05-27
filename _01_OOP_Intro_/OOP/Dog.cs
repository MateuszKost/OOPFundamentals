namespace _01_OOP_Intro_.OOP;

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }

    public override void Describe()
    {
        Console.WriteLine($"Dog - {Name}, {Age} years old");
    }
}
