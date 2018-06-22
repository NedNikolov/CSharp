using System;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 1; i <= n; i++)
            {
                string food = Console.ReadLine().ToLower();

                if (food.Equals("cheese"))
                {
                    calories += 500;
                }
                 else if (food.Equals("tomato sauce"))
                {
                    calories += 150;
                }
                 else if (food.Equals("salami"))
                {
                    calories += 600;
                }
                 else if (food.Equals("pepper"))
                {
                    calories += 50;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}
