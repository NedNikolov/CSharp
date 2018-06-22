using System;

namespace _01.ChooseADrink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();

            if (drink.Equals("Athlete"))
            {
                Console.WriteLine("Water");
            } else if (drink.Equals("Businessman") || drink.Equals("Businesswoman"))
            {
                Console.WriteLine("Coffee");
            } else if (drink.Equals("SoftUni Student"))
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
