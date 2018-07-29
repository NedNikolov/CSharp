using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                AddNewCarToList(cars, carInfo);
            }


            string command = Console.ReadLine();
            PrintSortedCars(cars, command);

            
        }

        private static void PrintSortedCars(List<Car> cars, string command)
        {
            if (command == "fragile")
            {
                cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.ToString()));
            }
            else
            {
                cars
                    .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.ToString()));
            }
        }

        private static void AddNewCarToList(List<Car> cars, string[] parameters)
        {
            
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            double tire1Pressure = double.Parse(parameters[5]);
            int tire1age = int.Parse(parameters[6]);
            double tire2Pressure = double.Parse(parameters[7]);
            int tire2age = int.Parse(parameters[8]);
            double tire3Pressure = double.Parse(parameters[9]);
            int tire3age = int.Parse(parameters[10]);
            double tire4Pressure = double.Parse(parameters[11]);
            int tire4age = int.Parse(parameters[12]);

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire[] tires = new Tire[4]
            {
                new Tire(tire1Pressure, tire1age),
                new Tire(tire2Pressure, tire2age),
                new Tire(tire3Pressure, tire3age),
                new Tire(tire4Pressure, tire4age)
            };

            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }
    }
}
