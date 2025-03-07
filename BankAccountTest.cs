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
    }
}
