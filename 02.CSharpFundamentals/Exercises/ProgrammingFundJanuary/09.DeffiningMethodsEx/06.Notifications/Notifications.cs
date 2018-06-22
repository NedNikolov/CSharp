using System;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input.Equals("success"))
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();                    
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (input.Equals("error"))
                {
                    var operation = Console.ReadLine();
                    var message = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, message));
                }
                else
                {
                    continue;
                }
            }
        }
        static string ShowSuccess(string operation, string message)
        {

            string result = "Successfully executed " + operation + ".\n" + "==============================\n" + "Message: " + message + ".";
            return result;



        }
        static string ShowError(string operation, int code)
        {
            string result = "Error: Failed to execute " + operation + ".\n" + "==============================\n" + "Error Code: " + code + ".\n";
            if (code > 0)
            {
                result += "Reason: Invalid Client Data.";
            }
            else
            {
                result += "Reason: Internal System Failure.";
            }
            return result;
        }
    }
}
