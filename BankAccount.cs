using System;
using System.Collections.Generic;

public class BankAccount
{
    // creating variables needed
    private string accountId;
    private string customerName;
    private decimal balance;
    private List<string> transactions;
    
    // Constructor -- empty for now
    public BankAccount(string customerName, decimal initialBalance) { }

    // Properties
    public string AccountId 
    { 
        get { return accountId; } 
    }

    public string CustomerName 
    { 
        get { return customerName; } 
    }

    public decimal Balance 
    { 
        get { return balance; } 
    }

    public List<string> Transactions 
    { 
        get { return transactions; } 
    }

    // Deposit method
    public bool Deposit(decimal amount)
    {
        // error checking
        if (amount <= 0)
        {
            return false;
        }

        // updating balance and adding to transaction history:
        balance += amount;
        transactions.Add($"Deposit: ${amount}");
        return true;
    }

    // Withdrawl method
    public bool Withdraw(decimal amount)
    {
        // error checking
        if (amount <= 0)
        {
            return false;
        }
        // checking for enough money
        if (amount > balance)
        {
            return false;
        }

        // updating balance and adding to transaction history:
        balance -= amount;
        transactions.Add($"Withdrawal: ${amount}");
        return true;
    }
}
        












    

}
