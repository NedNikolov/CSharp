using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.TestCode
{
    class TestCode
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                ["Gosho"] = 3,
                ["Pesho"] = 6,
                ["Ivann"] = 4,
                ["Ivan"] = 4,
                ["Stoqn"] = 5,
                ["Dimitar"] = 5,
            };

            students = students
                .OrderBy(s => s.Value)
                .ToDictionary(key => key.Key, val => val.Value);

            foreach (KeyValuePair<string, int> student in students.OrderBy(s => s.Value).ThenBy(s => s.Key.Length))
            {
                Console.WriteLine(student.Key + " => " + student.Value);
            }
        }
    }
}
