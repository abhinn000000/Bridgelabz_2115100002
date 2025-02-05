using System;
using System.Collections.Generic;
namespace CompanyManagement
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Position: " + Position);
        }
    }
    class Department
    {
        public string DepartmentName { get; set; }
        private List<Employee> Employees { get; set; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                employee.DisplayDetails();
            }
        }
    }
    class Company
    {
        public string CompanyName { get; set; }
        private List<Department> Departments { get; set; }

        public Company(string companyName)
        {
            CompanyName = companyName;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Departments:");
            foreach (var department in Departments)
            {
                department.DisplayDetails();
            }
        }
    }

    class program24
    {
        //static void Main()
        //{
        //    Company company = new Company("Razer Ent.");
        //    Department dept1 = new Department("Research and Development");
        //    Department dept2 = new Department("Sales and Marketing");
        //    Employee emp1 = new Employee("Ramesh", "Engineer");
        //    Employee emp2 = new Employee("Suresh", "Sales Manager");
        //    dept1.AddEmployee(emp1);
        //    dept2.AddEmployee(emp2);
        //    company.AddDepartment(dept1);
        //    company.AddDepartment(dept2);
        //    company.DisplayDetails();
        //    company = null;
        //}
    }
}