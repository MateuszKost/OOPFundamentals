using _02_Abstract_vs_Interface_vs_Virtual_.Models;

namespace _02_Abstract_vs_Interface_vs_Virtual_;

public static class Program
{
    public static void Main()
    {
        Animal dog = new Dog("Buddy");
        dog.Describe();     // Calls overridden method from Dog
        dog.MakeSound();    // Calls Dog's MakeSound()

        Animal cat = new Cat("Whiskers");
        cat.Describe();     // Calls base Animal Describe() (no override in Cat)
        cat.MakeSound();    // Calls Cat's MakeSound()

        // We use Bird type here to access both Animal methods and the IFlyable interface method Fly()
        // Using Animal type would not allow calling Fly(), even though Bird implements IFlyable.
        Bird bird = new Bird("Tweety");
        bird.Describe();    // Calls base Animal Describe()
        bird.MakeSound();   // Bird sound
        bird.Fly();         // Interface method

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}