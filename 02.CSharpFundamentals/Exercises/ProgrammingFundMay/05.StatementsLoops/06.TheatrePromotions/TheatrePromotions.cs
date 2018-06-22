using System;

namespace _06.TheatrePromotions
{
    class TheatrePromotions
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (input.Equals("Weekday"))
            {
                if ((age >= 0 && age <= 18)||(age > 64 && age <= 122))
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
            }
            else if (input.Equals("Weekend"))
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            else if (input.Equals("Holiday"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }

            if (age >= 0 && age < 123)
            {
                Console.WriteLine("{0}$", price);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
