﻿using System;

public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }
    public string Model { get; private set; }
    public string Driver { get; private set; }
    public string Brakes()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
    }
}