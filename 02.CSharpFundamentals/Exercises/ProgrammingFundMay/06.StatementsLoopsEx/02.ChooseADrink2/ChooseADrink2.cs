using System;

namespace _02.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            string proffesion = "";

            if (drink.Equals("Athlete"))
            {
                proffesion = "Athlete";
                price = quantity * 0.70;
            }
            else if (drink.Equals("Businessman"))
            {
                proffesion = "Businessman";
                price = quantity * 1.00;
            }
            else if (drink.Equals("Businesswoman"))
            {
                proffesion = "Businesswoman";
                price = quantity * 1.00;
            }
            else if (drink.Equals("SoftUni Student"))
            {
                proffesion = "SoftUni Student";
                price = quantity * 1.70;
            }
            else
            {
                proffesion = drink;
                price = quantity * 1.20;
            }
            Console.WriteLine("The {0} has to pay {1:f2}.", proffesion, price);
        }
    }
}
