using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int firstCicle = n / 2 - 1;
        int middleDot = 1;
        int middleDots = 1;
        int leftCicle = n - 1;
        int boddyDots = ((n*2)+1)-4;

        Console.Write(new string(dot, n));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, n));
        Console.WriteLine();

        for (int i = 0; i < firstCicle; i++)
        {
            Console.Write(new string(dot, leftCicle));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, middleDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, leftCicle));
            Console.WriteLine();
            middleDot+=2;
            leftCicle--;
        }
        leftCicle++;
        Console.Write(new string(star, leftCicle));
        Console.Write(new string(dot, middleDot));
        Console.Write(new string(star, leftCicle));
        Console.WriteLine();


        middleDot = 1;
        for (int i = 0; i < firstCicle; i++)
        {
            Console.Write(new string(dot, middleDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot,boddyDots ));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, middleDot));
            Console.WriteLine();
            middleDot++;
            boddyDots -= 2;
        }

        Console.Write(new string(dot, middleDot));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, boddyDots / 2));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, boddyDots / 2));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, middleDot));
        Console.WriteLine();

        middleDot--;
        for (int i = 0; i < firstCicle; i++)
        {
           
        Console.Write(new string(dot, middleDot));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, boddyDots / 2));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, middleDots));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, boddyDots / 2));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, middleDot));
        Console.WriteLine();
        middleDot--;
        middleDots += 2;
        }


        Console.Write(new string(star, leftCicle));
        Console.Write(new string(dot,((n*2)-1) - n));
        Console.Write(new string(star, leftCicle));
        Console.WriteLine();
    }
}

