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
            employee.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("\nJoining Date (mm/dd/yyyy): ");
            employee.JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("\nEnter Basic Salary: ");
            employee.basicSalary = Convert.ToDouble(Console.ReadLine()); // 40000

            Console.WriteLine("\nDEPARTMENTS:\n================================\n1. HR\n2. Finance\n3. Sales");
            Console.Write("\nInput any one serial number of the designations given above: ");
          
            department = (Department)Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter OT Hours: ");
            employee.otHours = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter OT Rate for a Hour: ");
            employee.otPrecent = Convert.ToDouble(Console.ReadLine());

            DataManipulataionForSales dataManipulataionForSales = new DataManipulataionForSales();

            if (department.Equals(Department.Sales))
            {
                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + employee.ID + "\nName: " + employee.FirstName + "  " + employee.LastName + "\nDate of Birth: " +
                    employee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + employee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    department + "\nTotal Basic Salary with OT :  " + " " + dataManipulataionForSales.GetTotalBasicSalary(employee));

                //Console.WriteLine("Sales");
            }
            else
            {
                Console.WriteLine("\n\nOUTPUTS\n================================");
                Console.WriteLine("\nEmployee ID: " + employee.ID + "\nName: " + employee.FirstName + "  " + employee.LastName + "\nDate of Birth: " +
                    employee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + employee.JoiningDateTime.ToShortDateString() + "\nDesignation: " +
                    department + "\nTotal Basic Salary with OT :  " + " " + dataManipulation.GetTotalBasicSalary(employee));
            }


        }
    }
}
