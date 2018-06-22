using System;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            miles *= (decimal)1.60934;

            Console.WriteLine("{0:F2}", miles);
        }
    }
}
