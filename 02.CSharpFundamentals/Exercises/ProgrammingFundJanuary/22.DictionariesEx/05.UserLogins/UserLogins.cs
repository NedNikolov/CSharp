using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersAndPasswords = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            bool isLogin = false;
            int counter = 0;

            while (input[0] != "end")
            {
                if (isLogin == false)
                {
                    usersAndPasswords[input[0]] = input[1];
                }
                else
                {
                    if (usersAndPasswords.ContainsKey(input[0]) && usersAndPasswords.ContainsValue(input[1]))
                    {
                        Console.WriteLine("{0}: logged in successfully", input[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0}: login failed", input[0]);
                        counter++;
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "login")
                {
                    isLogin = true;
                    input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }

            Console.WriteLine("unsuccessful login attempts: {0}", counter);
        }
    }
}
