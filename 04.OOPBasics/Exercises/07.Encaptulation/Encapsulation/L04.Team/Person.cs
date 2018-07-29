using System;
using System.Collections.Generic;
using System.Text;
public class Person
{
    const decimal MIN_SALARY = 460;
    const int MIN_LENGTH = 3;
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public Person(string firstName, string lastName, int age, decimal salary) : this(firstName, lastName, age)
    {
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value?.Length < MIN_LENGTH)
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value?.Length < MIN_LENGTH)
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            this.lastName = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            this.age = value;
        }
    }

    public decimal Salary
    {
        get { return this.salary; }
        set
        {
            if (value <= MIN_SALARY)
                throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
            this.salary = value;
        }
    }

    public void IncreaseSalary(decimal percent)
    {
        if (this.age > 30)
            this.salary += this.salary * percent / 100;
        else
            this.salary += this.salary * percent / 200;
    }

    private void ValidateFieldLength(string fieldValie, string fieldName)
    {
        if (fieldValie?.Length < 3)
            throw new ArgumentException(firstName + " cannot contain fewer than 3 symbols!");
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
    }
}

