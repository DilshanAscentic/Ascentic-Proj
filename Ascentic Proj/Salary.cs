using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj
{
    public class Salary
    {
        public double basicSalary = 40000;
        public double otHours;
        public double otPrecent;
        public double overtime;
        public double basicSalPrec;

        //public double SalaryAmountWithInc { get; private set; }

        public double CalculateOT( double otHours)
        {

            this.otPrecent = 120;
            this.otHours = otHours * otPrecent;
            //var otCal = this.basicSalary + otHours;
            var otCal = this.otHours;
            return otCal;

        }

        public double CalculateOTForSales(double otHours,int SalaryAmountWithInc)
        {

            this.otPrecent = 120;
            this.otHours = otHours * otPrecent;
            this.basicSalary = SalaryAmountWithInc;
            var otCal = this.basicSalary * 0.05 + this.otHours;
            //var otCal = this.otHours;
            return otCal;

        }


    }

  
}
