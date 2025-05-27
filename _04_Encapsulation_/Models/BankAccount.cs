namespace _04_Encapsulation_.Models;

/// <summary>
/// Demonstrates encapsulation using private fields and properties with get/set accessors.
/// </summary>
public class BankAccount
{
    /// <summary>
    /// Public read-only property for the account number.
    /// Can only be set through the constructor.
    /// Immutable: Once set during creation, it shouldn't be modified.
    /// </summary>
    public string AccountNumber { get; }

    // Private backing field
    private decimal _balance;
    
    /// <summary>
    /// Public property exposing the current balance.
    /// The setter is private — balance can only be modified internally (e.g. via Deposit/Withdraw).
    /// Prevents external code from setting an invalid balance directly.
    /// </summary>
    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
                return;
            }

            _balance = value;
        }
    }

    /// <summary>
    /// Public property for the owner's name.
    /// Demonstrates encapsulated validation logic in the setter.
    /// Can be modified by external code, but invalid values (e.g. empty) are rejected.
    /// </summary>
    private string _ownerName;
    
    public string OwnerName
    {
        get => _ownerName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Owner name cannot be empty.");
                return;
            }

            _ownerName = value;
        }
    }

    public BankAccount(string accountNumber, decimal initialDeposit, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialDeposit;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit must be positive.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal must be positive.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
    }
}

