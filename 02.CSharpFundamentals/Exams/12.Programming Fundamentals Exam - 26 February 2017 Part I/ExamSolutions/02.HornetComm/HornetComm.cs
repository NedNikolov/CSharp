using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (true)
            {               
                var input = Console.ReadLine().Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Hornet is Green")
                {
                    break;
                }
                if (input.Length != 2)
                {
                    input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                string leftPart = input[0];
                string rightPart = input[1];

                if (leftPart.All(char.IsDigit) && rightPart.All(char.IsLetterOrDigit))
                {
                    string reversed = new string(leftPart.ToCharArray().Reverse().ToArray());
                    messages.Add($"{reversed} -> {rightPart}");
                }
                else if (leftPart.All(c => !char.IsDigit(c)) && rightPart.All(char.IsLetterOrDigit))
                {
                    string reversedCases = ReversedCases(rightPart);
                    broadcasts.Add($"{reversedCases} -> {leftPart}");
                }

            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Count == 0 ? "None" : string.Join(Environment.NewLine, broadcasts));
            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Count == 0 ? "None" : string.Join(Environment.NewLine, messages));
        }

        private static string ReversedCases(string rightPart)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rightPart.Length; i++)
            {
                if (char.IsUpper(rightPart[i]))
                {
                    result.Append(char.ToLower(rightPart[i]));
                }
                else if (char.IsLower(rightPart[i]))
                {
                    result.Append(char.ToUpper(rightPart[i]));
                }
                else
                {
                    result.Append(rightPart[i]);
                }
            }

            return result.ToString();
        }
    }
}
