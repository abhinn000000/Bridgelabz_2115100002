using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Employee
    {
        //Attributes
        public int employeeID;
        protected string department;
        private int salary;

        //Constructor
        public Employee(int employeeID, string department, int salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        //Updating salary
        public void updateSalary()
        {
            Console.WriteLine("Enter the new salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        //displaying the details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The emplyee id is " + employeeID);
            Console.WriteLine("The department of the employee is " + department);
            Console.WriteLine("The salary of the employee is " + salary);
        }
    }

    class Manager : Employee
    {
        public Manager(int employeeID, string department, int salary) : base(employeeID, department, salary)
        {

        }

        public void updateEmployeeID()
        {
            Console.WriteLine("Enter the new Employee ID");
            employeeID = Convert.ToInt32(Console.ReadLine());
        }

        public void updateDepartment()
        {
            Console.WriteLine("Enter the new designated department");
            department = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
        }
    }

    class program14 {
        public static void Main(String[] args) {
            Employee employee1 = new Employee(789, "Testing", 88000);
            employee1.DisplayDetails();

            Manager employee2 = new Manager(654, "Software Development", 170000);
            employee2.DisplayDetails();
            employee2.updateEmployeeID(); // accessing employee ID in sub class
            employee2.DisplayDetails();
            employee2.updateDepartment(); // accessing department in sub class
            employee2.DisplayDetails();
        }
    }
}
