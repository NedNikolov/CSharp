using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\',' ');
            string newline = input[0];
            int counter = 0;
            while (newline != "Enough")
            {
              
                int dayOfWeek = 0;
                string daysOfWeek = (input[0]);
                switch (daysOfWeek)
                {
                    case "Monday":
                        dayOfWeek = 1;
                        break;
                    case "Tuesday":
                        dayOfWeek = 2;
                        break;
                    case "Wednesday":
                        dayOfWeek = 3;
                        break;
                    case "Thursday":
                        dayOfWeek = 4;
                        break;
                    case "Friday":
                        dayOfWeek = 5;
                        break;
                    case "Saturday":
                        dayOfWeek = 6;
                        break;
                    case "Sunday":
                        dayOfWeek = 7;
                        break;
                    default:
                        break;
                }

                string phoneNumber = (input[1]);

                int phoneNum = Convert.ToInt32(phoneNumber);
                int mask = 0;
                int sum = 0;
                while (phoneNum != 0)
                {
                    int reminder = phoneNum%10;
                    mask = phoneNum/10;
                    sum = sum + reminder;
                    phoneNum = mask;
                }

                string braSize = (input[2]);
                int bras = int.Parse(braSize.Substring(0, braSize.Length - 1));
                string letter = braSize.Substring(braSize.Length - 1, 1);



                int brasizeSum = bras*(Convert.ToInt32(letter[0]));

                string nameGirl = (input[3]);

                int sumirano = 0;
                for (int i = 0; i < 1; i++)
                {
                    char letterrr = nameGirl[i];
                    int lenght = nameGirl.Length;
                    sumirano = letterrr*lenght;
                }

                int finalSum = dayOfWeek + sum + brasizeSum - sumirano;

                if (finalSum <= 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", input[3]);
                }
                else
                {
                    Console.WriteLine("{0} is perfect for you.",input[3] );
                    counter++;
                }
                
                input = Console.ReadLine().Split('\\',' ');
                newline = input[0];

            }
            Console.WriteLine(counter);



        }
    }
}
