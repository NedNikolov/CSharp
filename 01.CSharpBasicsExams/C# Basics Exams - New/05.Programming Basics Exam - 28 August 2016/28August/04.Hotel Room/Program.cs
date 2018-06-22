using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double apartamentPricePerNight = 65;
            double studioPricePerNight = 50;

            if (month == "June" || month == "September")
            {
                apartamentPricePerNight = 68.7;
                studioPricePerNight = 72.2;
            }
            else if (month == "July" || month == "August")
            {
                apartamentPricePerNight = 77;
                studioPricePerNight = 76;
            }

            double studioPrice = studioPricePerNight * days;
            double apartamentPrice = apartamentPricePerNight * days;

            if ((month == "May" || month == "October") && days > 7 && days <=14)
            {
                studioPrice = studioPrice * 0.95;
                
            }
            else if ((month == "May" || month == "October") && days > 14)
            {
                studioPrice = studioPrice * 0.7;  
            }
            else if ((month == "June" || month == "September") && days > 7)
            {
                studioPrice = studioPrice * 0.8;
            }
            if (days > 14)
            {
                apartamentPrice = apartamentPrice * 0.9;
            }

            Console.WriteLine("Apartment price: {0:F2} lv." , apartamentPrice);
            Console.WriteLine("Studio price: {0:F2} lv." , studioPrice);
        
        }
    }
}
