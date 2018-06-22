using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            var destinationsTransportKindPlaces = new Dictionary<string, Dictionary<string, int>>();
            var destinationTrahsportPeople = Console.ReadLine();

            while (destinationTrahsportPeople !="ready")
            {
                var splited = destinationTrahsportPeople
                    .Split(new[] { ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
                var destionation = splited[0];
                var transportAndQuantity = splited;

                if (!destinationsTransportKindPlaces.ContainsKey(destionation))
                {
                    destinationsTransportKindPlaces[destionation] = new Dictionary<string, int>();
                }
                for (int index = 1; index < transportAndQuantity.Length; index += 2)
                {
                    var transport = transportAndQuantity[index];
                    var places = Convert.ToInt32(transportAndQuantity[index + 1]);

                    if (!destinationsTransportKindPlaces[destionation].ContainsKey(transport))
                    {
                        destinationsTransportKindPlaces[destionation][transport] = 0;
                    }
                    destinationsTransportKindPlaces[destionation][transport] = places;

                }

                destinationTrahsportPeople = Console.ReadLine();
            }

            destinationTrahsportPeople = Console.ReadLine();
            while (destinationTrahsportPeople!= "travel time!")
            {
                var splited = destinationTrahsportPeople.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var destination = splited[0];
                var peoples = Convert.ToInt32(splited[1]);

                var placesTo = 0;
                foreach (var places in destinationsTransportKindPlaces[destination])
                {
                    placesTo += places.Value;
                }
                if (peoples <= placesTo)
                {
                    Console.WriteLine($"{destination} -> all {peoples} accommodated");
                }
                else
                {
                    Console.WriteLine($"{destination} -> all except {peoples - placesTo} accommodated");
                }

                destinationTrahsportPeople = Console.ReadLine();
            }
        }
    }
}
