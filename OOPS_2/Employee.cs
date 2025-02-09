using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        //Attributes
        private string Name { get; set; }
        private int Id { get; set; }
        private double Salary { get; set; }

        //Constructor
        public Employee(string name,int id,double salary) {
            Name = name;
            Id = id;
            Salary = salary;
        }

        //Display details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The name of the employees is " + Name);
            Console.WriteLine("The Id of the employees is " + Id);
            Console.WriteLine("The salary of the employees is " + Salary);
        }
    }

    class Manager : Employee
    {
        //Constructor
        private int TeamSize { get; set; }
        public Manager(string Name, int Id, double Salary, int teamSize) : base(Name,Id,Salary) { //calling parent class constructor using base()
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The Team size of the Manager is "+ TeamSize);
        }
    }

    class Developer : Employee {
        //Attribute of Developer
        private string ProgrammingLanguage { get; set; }

        //Constructor
        public Developer(string Name,int Id,double Salary,string programmingLanguage) : base(Name,Id,Salary) {
            ProgrammingLanguage = programmingLanguage;
        }

        //Display Details method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The programming language of the developer is "+ProgrammingLanguage);
        }
    }

    class Intern : Employee {
        //Attribute
        private string InternshipDuration { get; set; }

        //Constructor
        public Intern(string Name, int Id, double Salary, string internshipDuration) : base(Name, Id, Salary) {
            InternshipDuration = internshipDuration;
        }

        //Method to display details of intern
        public override void DisplayDetails() {
            base.DisplayDetails();
            Console.WriteLine("The internship duration for the intern is "+InternshipDuration);
        }
    }

    class program2 {
        //public static void Main(String[] args)
        //{
        //    Employee employee1 = new Employee("Ajeet", 1, 10000.20);
        //    employee1.DisplayDetails();

        //    Manager manager1 = new Manager("Aviral", 2, 100000.54, 7);
        //    manager1.DisplayDetails();

        //    Developer developer1 = new Developer("Takeshi", 3, 89000.87, "C#");
        //    developer1.DisplayDetails();

        //    Intern intern1 = new Intern("Bobby", 4, 20000, "6 months");
        //    intern1.DisplayDetails();
        //}
    }
}
