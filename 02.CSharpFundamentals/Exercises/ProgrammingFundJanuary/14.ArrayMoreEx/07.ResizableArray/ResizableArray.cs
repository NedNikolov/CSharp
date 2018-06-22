﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ResizableArray
{
    class ResizableArray
    {
        static void Main(string[] args)
        {
            long?[] array = new long?[4];
            string input = Console.ReadLine();
            string[] command = new string[4];
            int index = 0;
            int overflow = 3;

            while (input != "end")
            {
                command = input.Split(' ');

                if (command[0] == "push")
                {
                    long number = long.Parse(command[1]);
                    array[index] = number;
                    index++;
                }
                else if (command[0] == "pop")
                {
                    array[index - 1] = null;
                    index--;
                }
                else if (command[0] == "removeAt")
                {
                    int toRemoveIndex = int.Parse(command[1]);
                    array[toRemoveIndex] = null;
                    for (int j = toRemoveIndex; j < index; j++)
                    {
                        array[j] = array[j + 1];
                        array[j + 1] = null;
                    }
                    index--;
                }
                else if (command[0] == "clear")
                {
                    for (int i = 0; i <= index; i++)
                    {
                        array[i] = null;
                    }
                    index = 0;
                }

                if (index == overflow)
                {
                    long?[] newArray = new long?[overflow + 1];
                    Array.Copy(array, newArray, overflow + 1);
                    overflow += 4;
                    array = new long?[overflow + 1];
                    Array.Copy(newArray, array, overflow - 3);
                }

                input = Console.ReadLine();
            }

            if (index <= 0)
            {
                Console.Write("empty array");
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
