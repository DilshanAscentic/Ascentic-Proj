using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj
{
    public class DataManipulation
    {
        Salary salary1 = new Salary();
        public int GetTotalBasicSalary(DateTime JoiningDateTime, double salary, int otHours)
        {
            // Employee employee = new Employee();



            int basicSalary = (int)salary1.basicSalary;
            TimeSpan age = DateTime.Now - JoiningDateTime;
            int years = age.Days / 365;
            int salaryWithInc = (int)(basicSalary + 1000 * years);

            double otPrecent = salary1.otPrecent;
            var otCal = otHours * otPrecent;

            salaryWithInc = (int)(salaryWithInc + otCal);


            return salaryWithInc;


        }

        public int GetTotalBasicSalaryFoSales(DateTime JoiningDateTime, double salary, int otHours)
        {

            int basicSalary = (int)salary1.basicSalary;

            TimeSpan age = DateTime.Now - JoiningDateTime;
            int years = age.Days / 365;

            //Salary Amount with work expireience
            int salaryWithInc = (int)(basicSalary + 1000 * years);

            double otPrecent = salary1.otPrecent;

            var otCal = otHours * otPrecent + salaryWithInc * 0.05;

            salaryWithInc = (int)(salaryWithInc + otCal);


            return salaryWithInc;

        }
    }
}
