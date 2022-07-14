using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj
{
    public class DataManipulation
    {
        // Employee employee = new Employee();
        public virtual int GetTotalBasicSalary(Employee employee)
        {

            TimeSpan age = DateTime.Now - employee.JoiningDateTime;
            int years = age.Days / 365;
            double salaryWithInc = employee.basicSalary + 1000 * years;

            double otCal = employee.otHours * employee.otPrecent;

            salaryWithInc = salaryWithInc + otCal;

            return (int)salaryWithInc;


        }

        //public int GetTotalBasicSalary(DateTime JoiningDateTime, double salary, double otHours)
        //{

        //    double basicSalary = employee.basicSalary;
        //    TimeSpan age = DateTime.Now - JoiningDateTime;
        //    int years = age.Days / 365;

        //    double salaryWithInc = basicSalary + 1000 * years;

        //    double otPrecent = employee.otPrecent;
        //    var otCal = otHours * otPrecent + salaryWithInc * 0.05;

        //    salaryWithInc = salaryWithInc + otCal;


        //    return (int)salaryWithInc;


        //}
    }

    public class DataManipulataionForSales : DataManipulation
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
