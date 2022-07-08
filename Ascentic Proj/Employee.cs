using System;
using System.Collections.Generic;
using System.Text;

namespace Ascentic_Proj
{
    public class Employee
    {
        public string ID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string Phone { get; set; }
        public  DateTime DateOfBirth { get; set; }

        public DateTime JoiningDateTime { get; set; }
        public string Department { get; set; }

        public Employee(string id, string firstName, string lastName, string email, string phone, DateTime DOB, DateTime joiningDateTime, int department)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = DOB;
            this.JoiningDateTime = joiningDateTime;
            this.Department = Enum.GetName(typeof(Department), department);
        }

        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }

        public  int GetTotalYearsOfWorkExpirience()
        {
            TimeSpan age = DateTime.Now - JoiningDateTime;
            int years = age.Days / 365;


            return years = Convert.ToInt32(years);
        }

        public string GetFullName()
        {
            return FirstName + LastName;
        }

    }
}
