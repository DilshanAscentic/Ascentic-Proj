using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj.LSP
{
    public class DataManipulationForOthers : SalaryCalculate
    {
        public override int GetTotalBasicSalary(Employee employee)
        {
            TimeSpan age = DateTime.Now - employee.JoiningDateTime;
            int years = age.Days / 365;
            double salaryWithInc = employee.basicSalary + 1000 * years;

            double otCal = employee.otHours * employee.otPrecent;

            salaryWithInc = salaryWithInc + otCal;

            return (int)salaryWithInc;
        }
    }
}
