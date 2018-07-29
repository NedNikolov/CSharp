using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {

        List<Department> departmens = new List<Department>();
        int peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            string[] empInput = Console.ReadLine().Split();
            string depName = empInput[3];           

            if (!departmens.Any(d => d.Name == depName))
            {
                Department dep = new Department(depName);
                departmens.Add(dep);
            }

            var department = departmens.First(d => d.Name == depName);
            Employee employee = ParseEmployee(empInput);
            
            department.AddEmployee(employee);
        }

        var highestAvgDep = departmens.OrderByDescending(d => d.AverageSalary).First();
        Console.WriteLine($"Highest Average Salary: {highestAvgDep.Name}");
        foreach (var emp in highestAvgDep.Employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}");
        }
    }

    static Employee ParseEmployee(string[] empInput)
    {
        string name = empInput[0];
        decimal salary = decimal.Parse(empInput[1]);
        string position = empInput[2];
        string mail = "n/a";
        int age = -1;

        if (empInput.Length == 6)
        {
            mail = empInput[4];
            age = int.Parse(empInput[5]);
        }
        else if (empInput.Length == 5)
        {
            bool isAge = int.TryParse(empInput[4], out age);
            if (!isAge)
            {
                mail = empInput[4];
                age = -1;
            }
        }

        Employee employee = new Employee(name, position, salary, age, mail);
        return employee;
    }
}

