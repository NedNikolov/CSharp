using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legionActivity = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, long>> soldiers = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new char[] {'=', '-', '>', ':', ' '}, StringSplitOptions.RemoveEmptyEntries);

                int activity = int.Parse(tokens[0]);
                string legionName = tokens[1];
                string type = tokens[2];
                long count = long.Parse(tokens[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, activity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(type))
                {
                    soldiers[legionName][type] = 0;
                }

                if (legionActivity[legionName] < activity)
                {
                    legionActivity[legionName] = activity;
                }

                soldiers[legionName][type] += count;

            }

            string[] conditions = Console.ReadLine().Split('\\');

            if (conditions.Length == 1)
            {
                string soldierType = conditions[0];
                foreach (KeyValuePair<string, int> legion in legionActivity.OrderByDescending(l => l.Value))
                {
                    if (soldiers[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                int searchedActivity = int.Parse(conditions[0]);
                string searchedsoldiers = conditions[1];

                foreach (var legion in soldiers.Where(l => l.Value.ContainsKey(searchedsoldiers)).OrderByDescending(l => l.Value[searchedsoldiers]))
                {
                    if (legionActivity[legion.Key] < searchedActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[searchedsoldiers]}");
                    }                    
                }
            }
        }
    }
}
