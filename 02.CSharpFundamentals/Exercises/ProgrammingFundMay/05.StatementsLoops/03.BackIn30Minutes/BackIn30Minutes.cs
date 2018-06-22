using System;

namespace _03.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            hours += minutes / 60;
            minutes = minutes % 60;

            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine("{0}:{1:d2}", hours, minutes);
        }
    }
}
