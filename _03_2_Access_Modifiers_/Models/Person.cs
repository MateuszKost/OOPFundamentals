namespace _03_2_Access_Modifiers_.Models;

/// <summary>
/// Demonstrates different access modifiers in a Person class.
/// </summary>
public class Person
{
    // Most restrictive — accessible only within this class
    private int _age;

    // A bit more open — accessible in this class and derived classes in the same assembly
    private protected string PrivateProtectedNote { get; set; }

    // Accessible in this class and any derived classes (even in other assemblies)
    protected string SecretNickname;

    // Accessible from any class in the same assembly
    internal string InternalCode { get; set; }

    // Accessible from derived classes OR from any class in the same assembly
    protected internal string ProtectedInternalInfo { get; set; }

    // Most open — accessible from any code anywhere
    public string Name { get; set; }

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