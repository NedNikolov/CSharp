using System;

class NewHouse
{
    static void Main()
    {
        string type = Console.ReadLine();
        decimal rows = decimal.Parse(Console.ReadLine());
        decimal columns = decimal.Parse(Console.ReadLine());
        decimal area = rows*columns;


        if (type == "Premiere")
        {
            Console.WriteLine("{0:0.00} leva", area * 12.00m);
        }
        else if (type == "Normal")
        {
            area = area ;
            Console.WriteLine("{0:0.00} leva", (area * 7.50m));
        }
        else
        {
            Console.WriteLine("{0:0.00} leva", area * 5.00m);
        }

    }
}
