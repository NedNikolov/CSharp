using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Pirate
{
    class Program
    {
        static void Main(string[] args)
        {
            double downloadData = double.Parse(Console.ReadLine());
            double cinemaPrice = double.Parse(Console.ReadLine());
            double wifeSpending = double.Parse(Console.ReadLine());
            
            double movieSize = 1500;
            double downloadTime = (((downloadData/2)/60)/60);
            double priceFordownload = downloadTime * wifeSpending;
            double numberOfmovies = downloadData/movieSize;
            double cinemaPricee = numberOfmovies * cinemaPrice;

            if (priceFordownload > cinemaPricee)
            {
                Console.WriteLine("cinema -> {0:0.00}lv", cinemaPricee);
            }
            else if (priceFordownload < cinemaPricee)
            {
                Console.WriteLine("mall -> {0:0.00}lv", priceFordownload);
            }
            else if (priceFordownload == cinemaPricee)
            {
                Console.WriteLine("mall -> {0:0.00}lv", priceFordownload);
            }
        }
    }
}
