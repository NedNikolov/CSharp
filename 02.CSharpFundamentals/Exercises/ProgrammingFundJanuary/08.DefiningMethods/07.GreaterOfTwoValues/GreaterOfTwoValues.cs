using System;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            

            switch (type)
            {
                case "int":
                {
                    int intOne = int.Parse(Console.ReadLine());
                    int intTwo = int.Parse(Console.ReadLine());

                    var greater = Max(intOne, intTwo);
                    Console.WriteLine(greater);
                    break;
                }
                    
                case "char":
                {
                    char intOne = char.Parse(Console.ReadLine());
                    char intTwo = char.Parse(Console.ReadLine());

                    var greater = Max(intOne, intTwo);
                    Console.WriteLine(greater);
                        break;
                }
                case "string":
                {
                    string intOne = Console.ReadLine();
                    string intTwo = Console.ReadLine();

                    var greater = Max(intOne, intTwo);
                    Console.WriteLine(greater);
                    break;
                    }

            }

        }
        static int Max(int one, int two)
        {
            if (one > two)
            {
                return one;
            }
            return two;

        }
        static char Max(char one, char two)
        {
            if (one > two)
            {
                return one;
            }
            return two;

        }
        static string Max(string one, string two)
        {
            if (one.CompareTo(two) >= 0)
            {
                return one;
            }
            return two;

        }



    }
}
