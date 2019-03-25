using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;

namespace P02_DatabaseFirst
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {

                //Console.WriteLine(GetEmployeesFullInformation(context));
                //Console.WriteLine(GetEmployeesWithSalaryOver50000(context));
                //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context));
                //Console.WriteLine(AddNewAddressToEmployee(context));
                //Console.WriteLine(GetEmployeesInPeriod(context));
                //Console.WriteLine(GetAddressesByTown(context));
                //Console.WriteLine(GetEmployee147(context));
                //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));
                //Console.WriteLine(GetLatestProjects(context));
                //Console.WriteLine(IncreaseSalaries(context));
                //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));
                //Console.WriteLine(DeleteProjectById(context));
                Console.WriteLine(RemoveTown(context));
            }
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employees = context.Employees
                .OrderBy(x => x.EmployeeId)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.MiddleName,
                    x.JobTitle,
                    x.Salary
                })
                .ToArray();


            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} " +
                                         $"{employee.JobTitle} {employee.Salary:F2}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder stringBuilde = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ToList();

            foreach (var employee in employees)
            {
                stringBuilde.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }
            return stringBuilde.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToList();

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} " +
                                         $"from {employee.DepartmentName} - ${employee.Salary:F2}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {

            StringBuilder stringBuilder = new StringBuilder();
            Address address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            //context.Addresses.Add(address);

            Employee nakov = context.Employees
                .FirstOrDefault(l => l.LastName == "Nakov");

            nakov.Address = address;

            context.SaveChanges();

            var employeeAddresses = context.Employees
                .OrderByDescending(a => a.AddressId)
                .Select(a => a.Address.AddressText)
                .Take(10)
                .ToList();

            foreach (var employeeAddress in employeeAddresses)
            {
                stringBuilder.AppendLine($"{employeeAddress}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {

            StringBuilder stringBuilder = new StringBuilder();
            var employees = context.Employees
                .Where(p => p.EmployeesProjects.Any(s => s.Project.StartDate.Year >= 2001 &&
                                                         s.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    EmployeeFullName = x.FirstName + " " + x.LastName,
                    ManagerFullName = x.Manager.FirstName + " " + x.Manager.LastName,
                    Projects = x.EmployeesProjects.Select(p => new
                    {
                        ProjectName = p.Project.Name,
                        StartDate = p.Project.StartDate,
                        EndDate = p.Project.EndDate
                    }).ToList()
                })
                .Take(30)
                .ToList();

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.EmployeeFullName} - Manager: " +
                                         $"{employee.ManagerFullName}");

                foreach (var project in employee.Projects)
                {
                    var startDate = project.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                    var hasEndDate = project.EndDate.HasValue ?
                        project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") :
                        "not finished";

                    stringBuilder.AppendLine($"--{project.ProjectName} - {startDate} - {hasEndDate}");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(t => t.Town.Name)
                .ThenBy(a => a.AddressText)
                .Select(a => new
                {
                    AddressText = a.AddressText,
                    TownName = a.Town.Name,
                    EmployeeCount = a.Employees.Count
                })
                .Take(10)
                .ToList();

            foreach (var address in addresses)
            {
                stringBuilder.AppendLine($"{address.AddressText}, {address.TownName} - " +
                                         $"{address.EmployeeCount} employees");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employee147 = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    FullName = e.FirstName + " " + e.LastName,
                    JobTitle = e.JobTitle,
                    Projects = e.EmployeesProjects
                        .Select(p => new
                            {
                                ProjectName = p.Project.Name,
                            }
                        )
                        .OrderBy(p => p.ProjectName)
                        .ToList()
                })
                .First();

            stringBuilder.AppendLine($"{employee147.FullName} - {employee147.JobTitle}");

            foreach (var project in employee147.Projects)
            {
                stringBuilder.AppendLine(project.ProjectName);
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var departments = context.Departments
                .Where(e => e.Employees.Count > 5)
                .OrderBy(e => e.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerFullName = d.Manager.FirstName + " " + d.Manager.LastName,
                    Employees = d.Employees.Select(e => new
                        {
                            EmployeeFullName = e.FirstName + " " + e.LastName,
                            JobTitle = e.JobTitle
                        })
                        .OrderBy(e => e.EmployeeFullName)
                })
                .ToList();

            foreach (var department in departments)
            {
                stringBuilder.AppendLine($"{department.DepartmentName} - {department.ManagerFullName}");
                foreach (var employee in department.Employees)
                {
                    stringBuilder.AppendLine($"{employee.EmployeeFullName} - {employee.JobTitle}");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {

            StringBuilder stringBuilder = new StringBuilder();

            var projects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .ToList();

            foreach (var project in projects)
            {
                stringBuilder.AppendLine(project.Name);
                stringBuilder.AppendLine(project.Description);
                stringBuilder.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt"));
            }
            return stringBuilder.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {

            StringBuilder stringBuilder = new StringBuilder();
            context.Employees
                .Where(e => new[] { "Engineering", "Tool Design", "Marketing", "Information Services" }
                    .Contains(e.Department.Name))
                .ToList()
                .ForEach(e => e.Salary *= 1.12m);

            context.SaveChanges();

            context.Employees
                .Where(e => new[] { "Engineering", "Tool Design", "Marketing", "Information Services" }
                    .Contains(e.Department.Name))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList()
                .ForEach(e => stringBuilder.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})"));

            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employees = context.Employees
                //.Where(e => EF.Functions.Like(e.FirstName, "sa%"))
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} - " +
                                         $"{employee.JobTitle} - (${employee.Salary:F2})");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employeeProjects = context.EmployeesProjects
                .Where(x => x.ProjectId == 2);

            context.EmployeesProjects.RemoveRange(employeeProjects);

            var project = context.Projects
                .FirstOrDefault(p => p.ProjectId == 2);

            context.Projects.Remove(project);

            context.SaveChanges();


            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();

            foreach (var currnetProject in projects)
            {
                stringBuilder.AppendLine(currnetProject);
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            string townName = "Seattle";

            var employees = context.Employees
                .Where(e => e.Address.Town.Name == townName)
                .ToList();
            //.ForEach(e => e.AddressId = null);

            foreach (var employee in employees)
            {
                employee.AddressId = null;
            }


            var addresses = context.Addresses
                .Where(a => a.Town.Name == townName)
                .ToList();

            //.ForEach(a => context.Addresses.Remove(a));

            // int addressesCount = addresses.Count();

            context.RemoveRange(addresses);

            context.Towns
                .Remove(context.Towns
                    .SingleOrDefault(t => t.Name == townName));

            context.SaveChanges();

            return $"{addresses.Count()} addresses in Seattle were deleted";
        }
    }
}
