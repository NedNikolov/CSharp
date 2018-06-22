using System;

namespace _02.VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double currBalance = double.Parse(Console.ReadLine());
            double money = 0;
            double totalSpent = 0;

            string input = Console.ReadLine();
            while (input !="Game Time")
            {
                if (input == "OutFall 4")
                {
                    money = 39.99;
                    if (currBalance >= money)
                    {
                        currBalance -= money;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "CS: OG")
                {
                    money = 15.99;
                    if (currBalance >= money)
                    {
                        currBalance -= money;
                        totalSpent += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    money = 19.99;
                    if (currBalance >= money)
                    {
                        currBalance -= money;
                        totalSpent += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    money = 59.99;
                    if (currBalance >= money)
                    {
                        currBalance -= money;
                        totalSpent += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    money = 29.99;
                    if (currBalance >= money)
                    {
                        currBalance -= money;
                        totalSpent += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    money = 39.99;
                    if (currBalance >= money)
                    {
                        currBalance -= money;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                input = Console.ReadLine();

            }

            if (currBalance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", totalSpent, currBalance);
            }
        }
    }
}
