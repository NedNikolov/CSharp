using System;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var beverage = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());

            double resultKcal = (ml * kcal) / 100.0;
            double resultG = (ml * g) / 100.0;

            Console.WriteLine("{0}ml {1}:", ml, beverage);
            Console.WriteLine("{0}kcal, {1}g sugars", resultKcal, resultG);
        }
    }
}
