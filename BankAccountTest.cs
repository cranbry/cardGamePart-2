using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bank Account Test");

        // Create a new bank account
        BankAccount account = new BankAccount("Mouad Oulouali", 1000.00m);
        Console.WriteLine($"Account name holder is: {account.CustomerName}");
        Console.WriteLine($"AccountID is: {account.AccountId}");
        Console.WriteLine($"Account balance is: {account.Balance}");

        // Test deposit
        Console.WriteLine("Testing deposit:");
        // depositing $500 into account
        bool depositResult = account.Deposit(500.00m);
        // returned value true if successful or false if not:
        Console.WriteLine($"Deposit successful: {depositResult}");
        // printing new balance after deposit
        Console.WriteLine($"New balance: ${account.Balance}");

        // Test withdraw
        Console.WriteLine("Testing withdrawal:");
        // withdrawing $200 from account
        bool withdrawResult = account.Withdraw(200.00m);
        // returned value true if successful or false if not:
        Console.WriteLine($"Withdrawal successful: {withdrawResult}");
        // printing new balance after withdraw
        Console.WriteLine($"New balance: ${account.Balance}");
        
    }
}
