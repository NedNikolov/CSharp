using System;

namespace _05.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();
            double priceParents = 0;
            double priceKids = 0;

            switch (destination)
            {
                case "Miami":
                    if (nights >= 1 && nights <=10)
                    {
                        priceParents = 24.99;
                        priceKids = 14.99;
                    }
                    else if (nights >= 11 && nights <=15)
                    {
                        priceParents = 22.99;
                        priceKids = 11.99;
                    }
                    else if (nights > 16)
                    {
                        priceParents = 20.00;
                        priceKids = 10.00;
                    }
                    break;
                case "Canary Islands":
                    if (nights >= 1 && nights <= 10)
                    {
                        priceParents = 32.5;
                        priceKids = 28.5;
                    }
                    else if (nights >= 11 && nights <= 15)
                    {
                        priceParents = 30.50;
                        priceKids = 25.60;
                    }
                    else if(nights > 16)
                    {
                        priceParents = 28.00;
                        priceKids = 22.00;
                    }
                    break;
                case "Philippines":
                    if (nights >= 1 && nights <= 10)
                    {
                        priceParents = 42.99;
                        priceKids = 39.99;
                    }
                    else if (nights >= 11 && nights <= 15)
                    {
                        priceParents = 41.00;
                        priceKids = 36.00;
                    }
                    else if (nights > 16)
                    {
                        priceParents = 38.50;
                        priceKids = 32.40;
                    }
                    break;
                default: break;
            }

            double parentsTrnasport = 0;
            double kidsTrnasport = 0;

            switch (transport)
            {
                case "train":
                    parentsTrnasport = 22.30;
                    kidsTrnasport = 12.50;
                    break;
                case "bus":
                    parentsTrnasport = 45.00;
                    kidsTrnasport = 37.00;
                    break;
                case "airplane":
                    parentsTrnasport = 90.00;
                    kidsTrnasport = 68.50;
                    break;
                default: break;
            }

            double sum = nights * (2 * priceParents + 3 * priceKids) * 1.25;
            double sum2 = 2 * parentsTrnasport + 3 * kidsTrnasport;

            Console.WriteLine("{0:f3}", sum + sum2);

        }
    }
}
