using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj
{
    public class Employee
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime JoiningDateTime { get; set; }
        public string Department { get; set; }

        public double basicSalary = 40000;

        public double otHours;

        public double otPrecent = 120;

        public double overtime;

        public double basicSalPrec;

    }
}
