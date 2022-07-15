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

        public double basicSalary { get; set; } 

        public double otHours { get; set; }

        public double otPrecent { get; set; } // 120

        public double overtime { get; set; }

        public double basicSalPrec { get; set; }

    }
}
