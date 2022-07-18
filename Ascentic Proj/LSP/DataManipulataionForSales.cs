using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj.LSP
{
    public class DataManipulataionForSales : SalaryCalculate
    {
        public override int GetTotalBasicSalary(Employee employee)
        {
            double basicSalary = employee.basicSalary;
            TimeSpan age = DateTime.Now - employee.JoiningDateTime;
            double years = age.Days / 365;
            double salaryWithInc = basicSalary + 1000 * years;

            double otPrecent = employee.otPrecent;
            var otCal = employee.otHours * otPrecent + salaryWithInc * 0.05;

            salaryWithInc = salaryWithInc + otCal;


            return (int)salaryWithInc;
        }
    }
}
