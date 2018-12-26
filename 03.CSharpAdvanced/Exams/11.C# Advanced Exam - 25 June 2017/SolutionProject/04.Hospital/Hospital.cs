﻿using System;
using System.Collections.Generic;
using System.Linq;

class Hospital
{
    static void Main()
    {
        var departments = new Dictionary<string, List<string>>();
        var doctors = new Dictionary<string, List<string>>();

        var input = Console.ReadLine();
        while (input != "Output")
        {
            var patientData = input.Split();
            var department = patientData[0];
            var doctor = patientData[1] + " " + patientData[2];
            var patient = patientData[3];
            if (departments.ContainsKey(department) == false)
            {
                departments.Add(department, new List<string>());
            }
            departments[department].Add(patient);

            if (doctors.ContainsKey(doctor) == false)
            {
                doctors.Add(doctor, new List<string>());
            }
            doctors[doctor].Add(patient);

            input = Console.ReadLine();
        }

        while (input != "End")
        {
            input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            var splitCommand = input.Split();
            if (splitCommand.Length == 1)
            {
                foreach (var patient in departments[input])
                {
                    Console.WriteLine(patient);
                }
            }
            else
            {
                int roomNumber = 0;
                if (int.TryParse(splitCommand[1], out roomNumber))
                {
                    var skip = 3 * (roomNumber - 1);
                    foreach (var patient in departments[splitCommand[0]].Skip(skip).Take(3).OrderBy(p => p))
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    foreach (var patient in doctors[input].OrderBy(p =>p))
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }

    }
}

