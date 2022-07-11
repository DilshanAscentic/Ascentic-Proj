using System;


namespace Ascentic_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Department department;

            DataManipulation dataManipulation = new DataManipulation();

            Console.Write("\nEnter ID: ");
            employee.ID = Console.ReadLine();


            Console.WriteLine("\nEnter First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("\nEnter Last Name: ");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("\nEnter Email");
            employee.Email = Console.ReadLine();

            Console.WriteLine("\nEnter Phone Number: ");
            employee.Phone = Console.ReadLine();

            Console.Write("\nEnter Date of Birth (mm/dd/yyyy): ");
            DateTime dateOfBarth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("\nJoining Date (mm/dd/yyyy): ");
            DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nDEPARTMENTS:\n================================\n1. HR\n2. Finance\n3. Sales");
            Console.Write("\nInput any one serial number of the designations given above: ");
            //employee.Department = Console.ReadLine();
            //employee.Department = Convert.ToString(Console.ReadLine());
            department = (Department)Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter OT Hours: ");
            employee.otHours = Convert.ToInt32(Console.ReadLine());


            if (department.Equals(Department.Sales))
            {
                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + employee.ID + "\nName: " + employee.FirstName + "  " + employee.LastName + "\nDate of Birth: " +
                    employee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + employee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    department + "\nTotal Basic Salary with OT :  " + " " + dataManipulation.GetTotalBasicSalary(JoiningDateTime, employee.basicSalary, employee.otHours));

                //Console.WriteLine("Sales");
            }
            else
            {
                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + employee.ID + "\nName: " + employee.FirstName + "  " + employee.LastName + "\nDate of Birth: " +
                    employee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + employee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    department + "\nTotal Basic Salary with OT :  " + " " + dataManipulation.GetTotalBasicSalary(JoiningDateTime, employee.otHours));
            }


        }
    }
}
