using System;


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

            string[] roles = anEmployee.GetRole(Console.ReadLine());

            // int increment = anEmployee.GetTotalYearsOfWorkExpirience();
            Console.WriteLine("\n\nOUTPUTS\n================================");
            Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.GetFullName() + "\nDate of Birth: " +
                anEmployee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + anEmployee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                anEmployee.Department + "\nTotal Work Years: " + anEmployee.GetTotalYearsOfWorkExpirience() + " ");
            
          

            Console.Write("\nEnter OT Hours: ");
            int otHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nSALARY\n================================");

           // doSalary();
            
            if (department == 3)
            {

                doSalaryForSales();
                Console.ReadLine();
                int exitCode = 0;
                Environment.Exit(exitCode);
            }
            else
            {
                doSalary();
            }

            //doSalaryForSales();

            void doSalary()
            {
                Salary s = new Salary();

                int yearsOfWork = anEmployee.GetTotalYearsOfWorkExpirience();

                //int SalaryAmountWithInc = (int)(s.basicSalary * yearsOfWork);
                int SalaryIncrement = 1000 * yearsOfWork;
                //Console.WriteLine(s.basicSalary * yearsOfWork);

                int SalaryAmountWithInc = (int)(s.basicSalary + SalaryIncrement);

                Console.WriteLine("\nTotal Salary Monthly: " + SalaryAmountWithInc);


                int otCalculator = (int)(SalaryAmountWithInc + s.CalculateOT(otHours));

                Console.WriteLine("\nTotal Salary Monthly with OT : " + otCalculator);
            }

            
            void doSalaryForSales()
            {
                Salary s = new Salary();

                int yearsOfWork = anEmployee.GetTotalYearsOfWorkExpirience();

                //int SalaryAmountWithInc = (int)(s.basicSalary * yearsOfWork);
                int SalaryIncrement = 1000 * yearsOfWork;
                //Console.WriteLine(s.basicSalary * yearsOfWork);

                int SalaryAmountWithInc = (int)(s.basicSalary + SalaryIncrement);

                Console.WriteLine("\nTotal Salary Monthly: " + SalaryAmountWithInc);


                int otCalculator = (int)(SalaryAmountWithInc + s.CalculateOTForSales(otHours,SalaryAmountWithInc));

                Console.WriteLine("\nTotal Salary Monthly with OT : " + otCalculator);
            }
            
        }
    }
}
