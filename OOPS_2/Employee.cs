using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    interface IDepartment {
        //abstract method to assign department
        void AssignDepartment() { }

        //abstract method to get department details
        void GetDepartmentDetails() { }

    }
    internal abstract class Employee
    {
        //Attributes
        private string employeeID;
        private string name;
        private double baseSalary;

        //Constructor
        public Employee(string employeeID,string name,double baseSalary){
            this.employeeID = employeeID;
            this.name = name;
            this.baseSalary = baseSalary;
            }

        //Encapsulation -------
        //get method for employeeID
        public string EmployeeID {
            get { return employeeID; }
        }

        //get method for employee name
        public string getName{
            get { return name; }
        }
        //set method to edit name
        public void setName(string value) {
            name = value;
        }

        //get method for baseSalary
        public double getBaseSalary {
            get { return baseSalary; }
        }

        //set method for baseSalary
        public void setSalary(double value) {
             baseSalary = value; 
        }

        //abstract method 
        public abstract void CalculateSalary();

        //concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("The id of the employee is " + EmployeeID);
            Console.WriteLine("The name of the employee is " + getName);
            Console.WriteLine("The salary of the employee is " + getBaseSalary);

        }
    }

    class FullTimeEmployee : Employee {

        //calling base class constructor using base()
        public FullTimeEmployee(string employeeID, string name, double baseSalary) : base(employeeID,name,baseSalary) {
        
        }

        //calculating full time employee salary
        public override void CalculateSalary()
        {
            setSalary(100000);
        }
    }

    class PartTimeEmployee : Employee {
        public PartTimeEmployee(string employeeID,string name,double baseSalary):base(employeeID,name,baseSalary) {
        
        }

        //calculating part time employee salary
        public override void CalculateSalary()
        {
            setSalary(25000);
        }
    }

    class program1 {
        //public static void Main(String[] args) {
        //    List <Employee> employees= new List<Employee> { 
        //        new FullTimeEmployee("101", "Animesh", 0),
        //        new FullTimeEmployee("102","Ajitesh",0),
        //        new PartTimeEmployee("103","Akhil",0),
        //    };

        //    foreach (Employee employee in employees) {
        //        employee.CalculateSalary();
        //        employee.DisplayDetails();
        //        Console.WriteLine();
        //    }
           
        //}
    }
}
