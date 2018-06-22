using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldPeople = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string transport = (Console.ReadLine());

            var oldPrice = 0.0;
            var studentsPrice = 0.0;
            var allPrice = 0.0;
            var pricePerNight = 82.99;
            var hotel = 0.0;
            var comission = 0.0;
            var vacantionCost = 0.0;

            if (transport == "train"  )
            {

                if (oldPeople + students <= 50.00)
                {

                    oldPrice = oldPeople * 24.99;
                    studentsPrice = students * 14.99;
                    allPrice = (oldPrice + studentsPrice) * 2;
                    hotel = pricePerNight * nights;
                    comission = (allPrice + hotel) * 0.10;
                    vacantionCost = allPrice + hotel + comission;
                    
                }
                else
                {
                    oldPrice = oldPeople * 24.99;
                    studentsPrice = students * 14.99;
                    allPrice = ((oldPrice + studentsPrice) * 2) * 0.5;
                    hotel = pricePerNight * nights;
                    comission = (allPrice + hotel) * 0.10;
                    vacantionCost = allPrice + hotel + comission; 
                    
                }

            }
            else if (transport == "bus")
            {

                oldPrice = oldPeople * 32.50;
                studentsPrice = students * 28.50;
                allPrice = (oldPrice + studentsPrice) * 2;
                hotel = pricePerNight * nights;
                comission = (allPrice + hotel) * 0.10;
                vacantionCost = allPrice + hotel + comission;
            }
            else if (transport == "boat")
            {

                oldPrice = oldPeople * 42.99;
                studentsPrice = students * 39.99;
                allPrice = (oldPrice + studentsPrice) * 2;
                hotel = pricePerNight * nights;
                comission = (allPrice + hotel) * 0.10;
                vacantionCost = allPrice + hotel + comission;

            }
            else if (transport == "airplane")
            {

                oldPrice = oldPeople * 70.00;
                studentsPrice = students * 50.00;
                allPrice = (oldPrice + studentsPrice) * 2;
                hotel = pricePerNight * nights;
                comission = (allPrice + hotel) * 0.10;
                vacantionCost = allPrice + hotel + comission;
                
            }
            Console.WriteLine("{0:f2}",vacantionCost);
        }
    }
}
