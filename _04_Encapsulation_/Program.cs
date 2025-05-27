using _04_Encapsulation_.Models;

namespace _04_Encapsulation_;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Encapsulation Example with Properties ===\n");

        var account = new BankAccount("ACC456", 500, "Alice");
        Console.WriteLine($"Account: {account.AccountNumber}");
        Console.WriteLine($"Owner: {account.OwnerName}");
        Console.WriteLine($"Balance: {account.Balance:C}\n");

        account.Deposit(300);
        account.Withdraw(100);

        // Trying to set an invalid name
        account.OwnerName = "";
        // Correct name change
        account.OwnerName = "Alice Smith";
        Console.WriteLine($"Updated Owner: {account.OwnerName}");

        // Cannot set balance or account number directly
        // account.Balance = 10000;         Not allowed
        // account.AccountNumber = "NEW";   Not allowed

        Console.WriteLine($"\nFinal Balance: {account.Balance:C}");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}