﻿using System;
using System.Linq;

public class Smartphones : IBrowseble, ICallable
{


    public string Browsing(string url)
    {
        if (url.Any(char.IsDigit))
        {
            return "Invalid URL!";
        }
        else
        {
            return $"Browsing: {url}!";
        }
    }

    public string Calling(string number)
    {
        if (!number.All(char.IsDigit))
        {
            return "Invalid number!";
        }
        else
        {
            return $"Calling... {number}";
        }
    }
}