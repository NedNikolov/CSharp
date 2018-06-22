using System;

class Program
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char genger = char.Parse(Console.ReadLine());
        int workouts = int.Parse(Console.ReadLine());
        double menValue = 66.5 + (13.75 *(weight / 2.2)) + (5.003 * (height * 2.54)) - (6.755 * age);
        double womenValue = 655 + (9.563 * (weight / 2.2)) + (1.850 * height * 2.54) - (4.676 * age);

        if (workouts == 0)
        {
            menValue = menValue * 1.2;
            womenValue = womenValue * 1.2;
        }
        else if (workouts >= 1 && workouts <= 3 )
        {
            menValue = menValue * 1.375;
            womenValue = womenValue * 1.375;
        }
        else if (workouts >= 4 && workouts <= 6)
        {
            menValue = menValue * 1.55;
            womenValue = womenValue * 1.55;
        }
        else if (workouts >= 7 && workouts <= 9)
        {
            menValue = menValue * 1.725;
            womenValue = womenValue * 1.725;
        }
        else
        {
            menValue = menValue * 1.9;
            womenValue = womenValue * 1.9;
        }

        if (genger == 'm')
        {
            Console.WriteLine(Math.Floor(menValue));
        }
        else
        {
            Console.WriteLine(Math.Floor(womenValue));
        }
    }
}

