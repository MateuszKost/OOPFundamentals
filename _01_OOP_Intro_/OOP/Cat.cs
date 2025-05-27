namespace _01_OOP_Intro_.OOP;

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}