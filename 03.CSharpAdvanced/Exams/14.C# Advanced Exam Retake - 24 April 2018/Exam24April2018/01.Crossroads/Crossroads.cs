using System;
using System.Collections;
using System.Collections.Generic;

class Crossroads
{
    static void Main()
    {
        Queue<string> cars = new Queue<string>();
        int greenLight = int.Parse(Console.ReadLine());
        int freeWindow = int.Parse(Console.ReadLine());
        
        

        int counter = 0;

        string input = Console.ReadLine();

        while (input != "END")
        {
            if (input != "green")
            {
                cars.Enqueue(input);
                input = Console.ReadLine();
                continue;
            }
            int currGreenLight = greenLight;
            string currCar = "";
            string outputCar = "";
            while (cars.Count > 0 && currGreenLight > 0)
            {
                currCar = cars.Dequeue();
                outputCar = currCar;
                currGreenLight -= currCar.Length;  // note!
                if (currGreenLight >= 0)
                {
                    counter++;
                    continue;
                }

                currCar = currCar.Remove(0, currCar.Length - currGreenLight * -1);
                currGreenLight += freeWindow;
                if (currGreenLight >= 0)
                {
                    counter++;
                    break;
                }
                currCar = currCar.Remove(0, currCar.Length - currGreenLight * -1);
                Console.WriteLine($"A crash happened!");
                Console.WriteLine($"{outputCar} was hit at {currCar[0]}.");
                Environment.Exit(0);
            }
            


            input = Console.ReadLine();
        }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");

    }
}