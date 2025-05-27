namespace _03_2_Access_Modifiers_.Models;

/// <summary>
/// Demonstrates different access modifiers in a Person class.
/// </summary>
public class Person
{
    // Public property accessible everywhere
    public string Name { get; set; }

    // Private field accessible only inside this class
    private int _age;

    // Protected field accessible in this class and derived classes
    protected string SecretNickname;

    // Internal property accessible within the same assembly
    internal string InternalCode { get; set; }

    // Protected internal property accessible in derived classes or same assembly
    protected internal string ProtectedInternalInfo { get; set; }

    // Private protected property accessible only in derived classes in the same assembly
    private protected string PrivateProtectedNote { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        _age = age;
        SecretNickname = "Secret_" + name;
        InternalCode = "INT" + age;
        ProtectedInternalInfo = "ProtectedInternal_" + name;
        PrivateProtectedNote = "PrivateProtected_" + name;
    }

    // Public method to get the private age field safely
    public int GetAge()
    {
        return _age;
    }

    // Protected method accessible in derived classes
    protected string RevealSecret()
    {
        return SecretNickname;
    }
}