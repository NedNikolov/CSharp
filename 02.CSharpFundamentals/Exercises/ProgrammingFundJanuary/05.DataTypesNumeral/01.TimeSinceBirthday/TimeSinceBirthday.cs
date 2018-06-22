using System;

namespace _01.TimeSinceBirthday
{
    class TimeSinceBirthday
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int days = input * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", input, days, hours, minutes);
            Console.WriteLine();
        }
    }
}
