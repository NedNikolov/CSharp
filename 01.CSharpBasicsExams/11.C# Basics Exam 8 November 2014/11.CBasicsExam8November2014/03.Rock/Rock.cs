using System;

  class RockLq
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char star = '*';
            int leftDots = n -2;
            int middleDots = n + 2;
            int hardCicle = n - 4;
            int finalCicle = n - 1;


            Console.Write(new string(dot, n));
            Console.Write(new string(star, n));
            Console.Write(new string(dot, n));
            Console.WriteLine();



            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dot, leftDots));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, middleDots));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, leftDots));
                Console.WriteLine();
                leftDots -= 2;
                middleDots += 4;
            }

                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n - 2));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n - 2));
                Console.Write(new string(star, 1));
                Console.WriteLine();

            middleDots = 1;

            for (int i = 1; i < n / 2; i++)
            {
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, hardCicle));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, middleDots));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, middleDots));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, hardCicle));
                Console.Write(new string(star, 1));
                Console.WriteLine();
                middleDots += 2;
                hardCicle -= 2;
            }

            middleDots = n;
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(dot, finalCicle));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, middleDots));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, finalCicle));
                Console.WriteLine();
                finalCicle--;
                middleDots += 2;
            }

            Console.Write(new string(star, n * 3));
            Console.WriteLine();
        }
 
}
