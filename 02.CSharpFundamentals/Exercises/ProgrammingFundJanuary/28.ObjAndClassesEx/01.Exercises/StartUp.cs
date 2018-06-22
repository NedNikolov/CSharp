using System;
using System.Collections.Generic;

public class StartUp
{
    static string topic = string.Empty;
    static string course = string.Empty;
    static string contestLink = string.Empty;
    static string[] problems;

    static List<Exercise> givenInformation = new List<Exercise>();

    public static void Main()
    {
        ReadSeveralInputLinesFrom(Console.ReadLine());
        PrintResultByGivenOrder();

    }

    static void PrintResultByGivenOrder()
    {
        foreach (var exercise in givenInformation)
        {
            Console.WriteLine($"Exercises: {exercise.Topic}");
            Console.WriteLine(
                $"Problems for exercises and homework for the \\\"{{exercise.CourceName}}\\\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
            var counter = 1;
            foreach (var item in exercise.Problems)
            {
                Console.WriteLine($"{counter}. {item}");
                counter++;
            }
        }
    }

    static void ReadSeveralInputLinesFrom(string readLine)
    {
        if (readLine != "go go go")
        {
            SplitAndParseToAllVariablesFrom(readLine);
            AddToListWithGivenInformation();
            ReadSeveralInputLinesFrom(Console.ReadLine());
        }
    }

    static void SplitAndParseToAllVariablesFrom(string readLine)
    {
        var splittedInput = readLine.Split(new[] {" -> ", ", "}, StringSplitOptions.RemoveEmptyEntries);
        topic = splittedInput[0];
        course = splittedInput[1];
        contestLink = splittedInput[2];
        problems = SkipThreeTake(splittedInput);
    }

    static string[] SkipThreeTake(string[] splitedInput)
    {
        problems = new string[splitedInput.Length - 3];
        for (int i = 3; i < splitedInput.Length; i++)
        {
            problems[i - 3] = splitedInput[i];
        }
        return problems;
    }

    static void AddToListWithGivenInformation()
    {
        var newExercise = new Exercise();
        newExercise.Topic = topic;
        newExercise.CourceName = course;
        newExercise.JudgeContestLink = contestLink;
        newExercise.Problems = new string[problems.Length];
        newExercise.Problems = problems;
        givenInformation.Add(newExercise);
    }
}

