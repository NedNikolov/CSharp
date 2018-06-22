using System;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubl = 0;
            double suite = 0;

            if (month.Equals("May") || month.Equals("October"))
            {
                if (month.Equals("May"))
                {
                    if (nights <= 7)
                    {
                        studio = 50 * nights;
                        doubl = 65 * nights;
                        suite = 75 * nights;
                    }
                    else
                    {
                        studio = (50 * 0.95) * nights;
                        doubl = 65 * nights;
                        suite = 75 * nights;
                    }
                }
                else
                {
                    if (nights <= 7)
                    {
                        studio = 50 * nights;
                        doubl = 65 * nights;
                        suite = 75 * nights;
                    }
                    else
                    {
                        studio = (50 * 0.95) * (nights - 1);
                        doubl = 65 * nights;
                        suite = 75 * nights;
                    }
                }
            } else if (month.Equals("June") || month.Equals("September"))
            {
                if (month.Equals("June"))
                {
                    if (nights <= 14)
                    {
                        studio = 60 * nights;
                        doubl = 72 * nights;
                        suite = 82 * nights;
                    }
                    else
                    {
                        studio = (60 * 0.90) * nights;
                        doubl = 72 * nights;
                        suite = 82 * nights;
                        
                    }
                } else if (month.Equals("September"))
                {
                    if (nights <= 7)
                    {
                        studio = 60 * nights;
                        doubl = 72 * nights;
                        suite = 82 * nights;
                    }
                    else if (nights > 7)
                    {
                        if (nights > 7 || nights <= 14)
                        {
                            studio = 60 * (nights - 1);
                            doubl = 72 * nights;
                            suite = 82 * nights;
                        }
                        else
                        {
                            studio = 60 * (nights - 1);
                            doubl = (72 * 0.90) * nights;
                            suite = 82 * nights;
                        }
                        
                    }
                }
            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                if (nights <= 14)
                {
                    studio = 68 * nights;
                    doubl = 77 * nights;
                    suite = 89 * nights;
                }
                else
                {
                    studio = 68 * nights;
                    doubl = 77 * nights;
                    suite = (89 * 0.85) * nights;
                }
            }
            Console.WriteLine("Studio: {0:f2} lv.", studio);
            Console.WriteLine("Double: {0:f2} lv.", doubl);
            Console.WriteLine("Suite: {0:f2} lv.", suite);
        }
    }
}
