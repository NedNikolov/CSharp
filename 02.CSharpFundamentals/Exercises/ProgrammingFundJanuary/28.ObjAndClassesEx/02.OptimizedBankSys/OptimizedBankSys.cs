using System;
using System.Collections.Generic;
using System.Linq;

public class BankAcount
{
    public string Name { get; set; }
    public string Bank { get; set; }
    public decimal Balance { get; set; }
}

public class OptimizedBankSys
{
    static string name = string.Empty;
    static string bank = string.Empty;
    static decimal balance = 0.0m;
    static List<BankAcount> bankAcounts = new List<BankAcount>();

    public static void Main()
    {
        ReadNextInformationFrom(Console.ReadLine());
        OrderBankAkounts();
        PrintAllInGivenOrder();
    }

    static void ReadNextInformationFrom(string input)
    {
        if (input != "end")
        {
            SplitAndParseCurrent(input);
            AddToBankAcounts();
            ReadNextInformationFrom(Console.ReadLine());
        }
        else return;
    }

    static void SplitAndParseCurrent(string input)
    {
        var splited = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
        name = splited[1];
        bank = splited[0];
        balance = Convert.ToDecimal(splited[2]);
    }

    static void AddToBankAcounts()
    {
        var newBankAcount = new BankAcount();
        newBankAcount.Name = name;
        newBankAcount.Bank = bank;
        newBankAcount.Balance = balance;
        bankAcounts.Add(newBankAcount);
    }

    static void OrderBankAkounts()
    {
        bankAcounts = bankAcounts.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length).ToList();
    }

    static void PrintAllInGivenOrder()
    {
        foreach (var acount in bankAcounts)
        {
            Console.WriteLine($"{acount.Name} -> {acount.Balance} ({acount.Bank})");
        }
    }
}

