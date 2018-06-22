using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var usersByAge = new Dictionary<string, string>();
            var usersBySalary = new Dictionary<string, double>();
            var usersByPlace = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "filter base")
            {
                var temporary = input.Split(' ');
                var name = temporary[0];
                var action = temporary[2];

                var integer = 0;
                var flotingpoint = 0.0;

                if (int.TryParse(action, out integer))
                {
                    usersByAge[name] = action;
                }
                else if (double.TryParse(action, out flotingpoint))
                {
                    usersBySalary[name] = flotingpoint;
                }
                else
                {
                    usersByPlace[name] = action;
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (KeyValuePair<string, string> value in usersByAge)
                {
                    Console.WriteLine("Name: {0}\nAge: {1}", value.Key, value.Value);
                    Console.WriteLine("====================");
                }
            }

            else if (input == "Salary")
            {
                foreach (KeyValuePair<string, double> value in usersBySalary)
                {
                    Console.WriteLine("Name: {0}\nSalary: {1:F2}", value.Key, value.Value);
                    Console.WriteLine("====================");
                }
            }

            else
            {
                foreach (KeyValuePair<string, string> value in usersByPlace)
                {
                    Console.WriteLine("Name: {0}\nPosition: {1}", value.Key, value.Value);
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
