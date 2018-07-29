﻿using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var persons = new List<Person>();
        var lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();

            try
            {
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        var bonus = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p));
    }
}