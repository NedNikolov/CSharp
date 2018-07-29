﻿using System;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workingHours;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHours)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHours = workingHours;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public decimal WorkingHours
    {
        get
        {
            return this.workingHours;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workingHours = value;
        }
    }

    private decimal SalaryPerHour()
    {
        return (this.WeekSalary / 5) / this.WorkingHours;
    }

    public override string ToString()
    {
        return $@"First Name: {this.FirstName}" + Environment.NewLine +
            $"Last Name: {this.LasttName}" + Environment.NewLine +
            $"Week Salary: {this.WeekSalary:f2}" + Environment.NewLine + 
            $"Hours per day: {this.WorkingHours:f2}" + Environment.NewLine +
            $"Salary per hour: {(SalaryPerHour()):f2}";

    }
}