namespace _03_2_Access_Modifiers_.Models;

/// <summary>
/// Employee inherits from Person and can access protected members.
/// </summary>
public class Employee : Person
{
    public Employee(string name, int age) : base(name, age) { }

    public void ShowInfo()
    {
        // Can access public member
        Console.WriteLine($"Name: {Name}");

        // Cannot access private _age directly, must use public method
        Console.WriteLine($"Age: {GetAge()}");

        // Can access protected member (inherited)
        Console.WriteLine($"Secret Nickname: {RevealSecret()}");

        // Can access internal member (same assembly)
        Console.WriteLine($"Internal Code: {InternalCode}");

        // Can access protected internal member
        Console.WriteLine($"Protected Internal Info: {ProtectedInternalInfo}");

        // Can access private protected member (same assembly + derived)
        Console.WriteLine($"Private Protected Note: {PrivateProtectedNote}");
    }
}