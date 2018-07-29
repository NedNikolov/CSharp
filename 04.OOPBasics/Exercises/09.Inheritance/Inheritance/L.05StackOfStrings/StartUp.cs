using System;

public class StartUp
{
    public static void Main()
    {
        StackOfStrings neu = new StackOfStrings();
        neu.Push("asdd");
        neu.Push("asddddddddd");
        neu.Push("asddsad");

        Console.WriteLine(neu.Peek());
        Console.WriteLine(neu.Peek());
        Console.WriteLine(neu.Peek());
        neu.Push("eeeeeeee");
        Console.WriteLine(neu.Pop());
        Console.WriteLine(neu.Pop());
        Console.WriteLine(neu.Pop());
    }
}

