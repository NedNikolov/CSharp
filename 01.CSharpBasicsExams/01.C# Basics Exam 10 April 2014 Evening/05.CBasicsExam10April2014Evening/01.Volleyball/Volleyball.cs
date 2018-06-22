using System;

namespace _01.Volleyball
{
    internal class Volleyball
    {
        private static void Main(string[] args)
        {

            string year = Console.ReadLine();
            double holiday = int.Parse(Console.ReadLine());
            double hometown = int.Parse(Console.ReadLine());
            double totalWeekends = 48;
            double normalweekends = totalWeekends - hometown;
            double normalweekendsSum = normalweekends*3/4;
            double holidayPlays = holiday*2/3;
            double normalweekendsPlay = hometown + normalweekendsSum + holidayPlays;
            double leapweekendsPlay = normalweekendsPlay + (normalweekendsPlay*0.15);

                if (year == "leap")
                {
                    Console.WriteLine(Math.Floor(leapweekendsPlay));
                }
                else
                {
                    Console.WriteLine(Math.Floor(normalweekendsPlay));
                }
            }
        }
}
