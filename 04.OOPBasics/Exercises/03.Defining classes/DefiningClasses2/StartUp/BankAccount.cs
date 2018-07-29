using System;
using System.Reflection.Metadata;

public class BankAccount
{
    int id;

    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    decimal balance;

    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            Balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"Account ID{ID}, balance {Balance:F2}";
    }
}