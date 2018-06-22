using System;

namespace _07.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double subtotal = 0;

            for (int i = 1; i <= n; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount == 1)
                {
                    Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
                    subtotal += itemPrice * itemCount;
                }
                else
                {
                    Console.WriteLine("Adding {0} {1}s to cart.", itemCount, itemName);
                    subtotal += itemPrice * itemCount;
                }
                

            }

            if (budget >= subtotal)
            {
                Console.WriteLine("Subtotal: ${0:F2}", subtotal);
                Console.WriteLine("Money left: ${0:F2}", budget - subtotal);
            }
            else
            {
                Console.WriteLine("Subtotal: ${0:F2}", subtotal);
                Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(budget - subtotal));
            }
        }
    }
}
