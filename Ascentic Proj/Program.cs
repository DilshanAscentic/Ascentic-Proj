﻿using System;


namespace Ascentic_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT INFORMATION\n================================");

            Console.Write("\nEnter ID: ");
            string id = Console.ReadLine();

            Console.WriteLine("\nEnter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nEnter Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nEnter Email");
            string email = Console.ReadLine();

            Console.WriteLine("\nEnter Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("\nEnter Date of Birth (mm/dd/yyyy): ");
            DateTime dateOfBarth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("\nJoining Date (mm/dd/yyyy): ");
            DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nDEPARTMENTS:\n================================\n1. HR\n2. Finance\n3. Sales");
            Console.Write("\nInput any one serial number of the designations given above: ");
            int department = Int32.Parse(Console.ReadLine());

            Employee anEmployee = new Employee(id, firstName, lastName, email, phone, dateOfBarth, JoiningDateTime, department);
            //Employee anEmployee = new Employee();
            Salary salary = new Salary();

            DataManipulation dataManipulation = new DataManipulation();

            Console.Write("\nEnter OT Hours: ");
            int otHours = Convert.ToInt32(Console.ReadLine());

            if (department == 3)
            {
                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.FirstName + "  " + anEmployee.LastName + "\nDate of Birth: " +
                    anEmployee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + anEmployee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    anEmployee.Department + "\nTotal Basic Salary with OT : " + " " + dataManipulation.GetTotalBasicSalaryFoSales(JoiningDateTime, salary.basicSalary, otHours));
            }
            else
            {
                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.FirstName + "  " + anEmployee.LastName + "\nDate of Birth: " +
                    anEmployee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + anEmployee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    anEmployee.Department + "\nTotal Basic Salary with OT : " + " " + dataManipulation.GetTotalBasicSalary(JoiningDateTime, salary.basicSalary, otHours));
            }



        }
    }
}
