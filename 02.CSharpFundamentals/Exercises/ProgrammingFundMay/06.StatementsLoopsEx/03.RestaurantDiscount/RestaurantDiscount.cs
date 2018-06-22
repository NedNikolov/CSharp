using System;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            double groupSize = int.Parse(Console.ReadLine());
            string typePackage = Console.ReadLine();
            string halls = "";
            double priceHall = 0;

            

            if (groupSize <= 50 && groupSize > 0)
            {
                halls = "Small Hall";
                priceHall = 2500;
            } else if (groupSize > 50 && groupSize <=100)
            {
                halls = "Terrace";
                priceHall = 5000;
            } else if (groupSize > 100 && groupSize <= 120)
            {
                halls = "Great Hall";
                priceHall = 7500;
            }
            

            if (typePackage.Equals("Normal"))
            {
                priceHall = priceHall + 500;
                priceHall *= 0.95;
                priceHall /= groupSize;
            } else if (typePackage.Equals("Gold"))
            {
                priceHall = priceHall + 750;
                priceHall *= 0.9;
                priceHall /= groupSize;
            } else if (typePackage.Equals("Platinum"))
            {
                priceHall = priceHall + 1000;
                priceHall *= 0.85;
                priceHall /= groupSize;
            }

            if (groupSize > 0 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the {0}", halls);
                Console.WriteLine("The price per person is {0:f2}$", priceHall);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
