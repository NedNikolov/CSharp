using System;
using System.Linq;

namespace _04.Phone
{
    class Phone
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            int minutes = 0;
            int seconds = 0;
            int sum = 0;
            string message = "";
            

            string[] operation = Console.ReadLine().Split(' ').ToArray();
            while (operation[0] != "done")
            {
                if (operation[0] == "call")
                {
                    minutes = 0;
                    seconds = 0;
                    sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (operation[1] == numbers[i])
                        {
                            message = names[i];
                            for (int j = 0; j < numbers[i].Length; j++)
                            {
                                string number = numbers[i];
                                if (char.IsDigit(number[j]))
                                {
                                    sum += int.Parse(number[j].ToString());
                                }
                            }

                            if (sum % 2 == 0)
                            {
                                minutes = sum / 60;
                                seconds = sum - (60 * minutes);
                                Console.WriteLine("calling {0}...", message);
                                Console.WriteLine("call ended. duration: {0:D2}:{1:D2}", minutes, seconds);
                            }
                            else
                            {
                                Console.WriteLine("calling {0}...", message);
                                Console.WriteLine("no answer");
                            }
                        }
                        else if (operation[1] == names[i])
                        {
                            message = numbers[i];
                            for (int j = 0; j < numbers[i].Length; j++)
                            {
                                string number = numbers[i];
                                if (char.IsDigit(number[j]))
                                {
                                    sum += int.Parse(number[j].ToString());
                                }
                            }

                            if (sum % 2 == 0)
                            {
                                minutes = sum / 60;
                                seconds = sum - (60 * minutes);
                                Console.WriteLine("calling {0}...", message);
                                Console.WriteLine("call ended. duration: {0:D2}:{1:D2}", minutes, seconds);
                                
                            }
                            else
                            {
                                Console.WriteLine("calling {0}...", message);
                                Console.WriteLine("no answer");
                            }
                        }

                    }
                }
                else
                {
                    minutes = 0;
                    seconds = 0;
                    sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (operation[1] == numbers[i])
                        {
                            message = names[i];
                            for (int j = 0; j < numbers[i].Length; j++)
                            {
                                string number = numbers[i];
                                if (char.IsDigit(number[j]))
                                {
                                    sum += int.Parse(number[j].ToString());
                                }
                            }

                            if (sum % 2 == 0)
                            {
                                Console.WriteLine("sending sms to {0}...", message);
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("sending sms to {0}...", message);
                                Console.WriteLine("busy");
                            }
                        }
                        else if (operation[1] == names[i])
                        {
                            message = numbers[i];
                            for (int j = 0; j < numbers[i].Length; j++)
                            {
                                string number = numbers[i];
                                if (char.IsDigit(number[j]))
                                {
                                    sum += int.Parse(number[j].ToString());
                                }
                            }

                            if (sum % 2 == 0)
                            {
                                Console.WriteLine("sending sms to {0}...", message);
                                Console.WriteLine("meet me there");

                            }
                            else
                            {
                                Console.WriteLine("sending sms to {0}...", message);
                                Console.WriteLine("busy");
                            }
                        }

                    }
                }
                operation = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
