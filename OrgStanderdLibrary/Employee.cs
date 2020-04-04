using System;

namespace OrgStanderdLibrary
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double SalaryPerDay { get; set; }
        public double HRA { get; set; }


        public double GetSalary(int NumberOfLeavesTaken)
        {
            int Year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int NumberOfKingDays = DateTime.DaysInMonth(Year, month);
            int NumberOfDaysPresent = NumberOfKingDays - NumberOfLeavesTaken;

            double BasicSalary = NumberOfDaysPresent * this.SalaryPerDay;
            double HRASalary = (BasicSalary * this.HRA) / 100;
            double GrossSalary = BasicSalary + HRASalary;

            return GrossSalary;
        }

    }
}
