using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AvrgStudentGrades
{
    class AvrgStudentGrades
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> pair in grades)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;

                var average = studentGrades.Average();

                Console.Write("{0} -> ", name);

                foreach (var grade in studentGrades)
                {
                    Console.Write("{0:F2} ", grade);
                }

                Console.WriteLine("(avg: {0:F2})", average);
            }
        }
    }
}
