using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj
{
    public class DataManipulation
    {
        Employee employee = new Employee();
        public int GetTotalBasicSalary(DateTime JoiningDateTime, double otHours)
        {
            double basicSalary = employee.basicSalary;
            TimeSpan age = DateTime.Now - JoiningDateTime;
            int years = age.Days / 365;
            double salaryWithInc = basicSalary + 1000 * years;

            double otPrecent = employee.otPrecent;
            var otCal = otHours * otPrecent;

            salaryWithInc = salaryWithInc + otCal;

            return (int)salaryWithInc;


        }

        public int GetTotalBasicSalary(DateTime JoiningDateTime, double salary, double otHours)
        {

            double basicSalary = employee.basicSalary;
            TimeSpan age = DateTime.Now - JoiningDateTime;
            int years = age.Days / 365;

            double salaryWithInc = basicSalary + 1000 * years;

            double otPrecent = employee.otPrecent;
            var otCal = otHours * otPrecent + salaryWithInc * 0.05;

            salaryWithInc = salaryWithInc + otCal;


            return (int)salaryWithInc;


        }
    }
}
