using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DecryptTheMessage
{
    class DecryptTheMessage
    {
        static void Main(string[] args)
        {
            string inputString;
            int msgCounter = 0;
            List<string> msges = new List<string>();

            do
            {
                 inputString = Console.ReadLine();

            } while (inputString.ToUpper() != "START");

            inputString = Console.ReadLine();

            while (inputString.ToUpper() != "END")
            {
                if (inputString != "")
                {
                    msgCounter++;
                    string decryptedMsg = "";
                    for (int symbol = 0; symbol < inputString.Length; symbol++)
                    {
                        if ((inputString[symbol] >= 'A') && (inputString[symbol] <= 'Z') || (inputString[symbol] >= 'a') && (inputString[symbol] <= 'z'))
                        {
                            if ((inputString[symbol] >= 'A') && (inputString[symbol] <= 'M') ||
                                (inputString[symbol] >= 'a') && (inputString[symbol] <= 'm'))
                            {
                                decryptedMsg += (char)(inputString[symbol] + 13);
                            }
                            else
                            {
                                decryptedMsg += (char)(inputString[symbol] - 13);
                            }
                        }
                        else 
                        {
                            switch (inputString[symbol])
                            {
                                case '%':
                                    decryptedMsg += ',';
                                    break;
                                case '+':
                                    decryptedMsg += ' ';
                                    break;
                                case '&':
                                    decryptedMsg += '.';
                                    break;
                                case '#':
                                    decryptedMsg += '?';
                                    break;
                                case '$':
                                    decryptedMsg += '!';
                                    break;
                                default:
                                    decryptedMsg += inputString[symbol];
                                    break;
                            }

                        }
                    }
                    //Array.Reverse(decryptedMsg.ToCharArray());
                    char[] reversedArray = decryptedMsg.ToCharArray();
                    Array.Reverse(reversedArray);
                    decryptedMsg = new string(reversedArray);

                    msges.Add(decryptedMsg);
                }

                inputString = Console.ReadLine();
            }
            if (msges.Count != 0)
            {
                Console.WriteLine("Total number of messages: {0}", msges.Count);
                foreach (var msg in msges)
                {
                    Console.WriteLine(msg);
                }
            }
            else
            {
                Console.WriteLine("No message received.");
            }

        }
    }
}
