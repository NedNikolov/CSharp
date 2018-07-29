using System;

public class StartUp
{
    public static void Main()
    {
        var studentSystem = new StudentSystem();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Exit") break;

            studentSystem.ParseCommand(command, Console.WriteLine);
        }
    }
}

