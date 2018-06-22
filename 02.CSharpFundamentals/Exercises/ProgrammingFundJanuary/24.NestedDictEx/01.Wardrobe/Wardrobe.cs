using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int inputCounter = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCounter; cnt++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                string color = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (string cloth in clothes)
                {
                    Dictionary<string, int> clothDatabase = wardrobe[color];

                    if (!clothDatabase.ContainsKey(cloth))
                    {
                        clothDatabase.Add(cloth, 0);
                    }

                    clothDatabase[cloth]++;
                }
            }

            string[] searchTokens = Console.ReadLine().Split(' ');
            string searchedColor = searchTokens[0];
            string searchedCloth = searchTokens[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> colorData in wardrobe)
            {
                string color = colorData.Key;
                Dictionary<string, int> clothesData = colorData.Value;

                Console.WriteLine("{0} clothes:", color);
                foreach (KeyValuePair<string, int> clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;
                    Console.Write("* {0} - {1}", cloth, quantity);

                    if (color == searchedColor && cloth == searchedCloth)
                    {
                        Console.Write(" (found!) ");
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
