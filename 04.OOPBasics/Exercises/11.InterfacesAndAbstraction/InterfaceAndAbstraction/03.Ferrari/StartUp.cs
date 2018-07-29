using System;
public class StartUp
{
    public static void Main()
    {
        var driverName = Console.ReadLine();
        Ferrari ferrari = new Ferrari(driverName);
        Console.WriteLine(ferrari);
    }
}