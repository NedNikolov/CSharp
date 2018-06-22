using System;
using System.Globalization;
using System.Threading;

namespace _04.FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}
