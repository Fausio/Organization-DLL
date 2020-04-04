using System;
using OrgStanderdLibrary;

namespace OrganizationConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Fausio",
                SalaryPerDay = 300,
                HRA = 6.2
            };

            Console.WriteLine("The gross salary of {0} is {1}", employee.Name, employee.GetSalary(5));

            Console.ReadKey();
        }
    }
}
