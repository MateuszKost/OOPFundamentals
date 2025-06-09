namespace _05_Constructors_And_Overloading_.Models;

/// <summary>
/// Demonstrates constructor overloading and chaining.
/// </summary>
public class Person
{
    private const string Unknown = "Unknown";
    
    /// <summary>
    /// Additionally:
    /// We can use private readonly fields here because they are only set once in the constructor
    /// and should not be modified afterward. This enforces immutability after object creation.
    /// </summary>
    private readonly int _age;
    private readonly string _country;
    private readonly string _name;

    // Default constructor
    public Person()
    {
        _age = 0;
        _country = Unknown;
        _name = Unknown;
        Console.WriteLine("Default constructor called");
    }

    // Constructor with one parameter
    public Person(string name)
    {
        _age = 0;
        _country = Unknown;
        _name = name;
        Console.WriteLine("Constructor with name called");
    }

    // Constructor with two parameters
    public Person(string name, int age)
    {
        _age = age;
        _country = Unknown;
        _name = name;
        Console.WriteLine("Constructor with name and age called");
    }

    // Constructor with all parameters using constructor chaining
    public Person(string name, int age, string country) : this(name, age)
    {
        _country = country;
        Console.WriteLine("Constructor with name, age, and country called");
    }

    public void ShowInformation()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}, Country: {_country}");
    }
}
