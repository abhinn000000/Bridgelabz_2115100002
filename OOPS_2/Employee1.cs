using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{       //Attributes
    internal class Employee1    {
        private static string CompanyName = "Oodles Enterprises";
        private static int totalEmployees = 0;
        private string name;
        private readonly int EmployeeID;
        private string designation;

        //Constructor
        public Employee1(string name, int EmployeeID, string designation)
        {
            this.name = name;
            this.EmployeeID = EmployeeID;
            this.designation = designation;
            totalEmployees++;
        }

        public int GetTotalEmployees()
        {
            return totalEmployees;
        }

        //displaying details
        public void DisplayDetails()
        {
            if (this is Employee1)
            {
                Console.WriteLine("The total number of employees is " + GetTotalEmployees());
                Console.WriteLine("The name of the employee is " + name);
                Console.WriteLine("The Employee ID of the employee is " + EmployeeID);
                Console.WriteLine("The designation of the employee is " + designation);
            }
        }

    }

    class program17
    {
        //public static void Main(String[] args)
        //{
        //    Employee1 employee1 = new Employee1("Ashish", 789, "Manager");
        //    Employee1 employee2 = new Employee1("Aswinder", 790s, "Manager");
        //    employee1.DisplayDetails();

        //}
    }
}
