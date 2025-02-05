using System;
using System.Collections.Generic;
namespace UniversityManagement
{
    class Faculty
    {
        public string FacultyName { get; set; }
        public Faculty(string facultyName)
        {
            FacultyName = facultyName;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Faculty Name: " + FacultyName);
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        private List<Faculty> Faculties { get; set; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Faculties = new List<Faculty>();
        }

        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("Faculties:");
            foreach (var faculty in Faculties)
            {
                faculty.DisplayDetails();
            }
        }
    }

    class University
    {
        public string UniversityName { get; set; }
        private List<Department> Departments { get; set; }

        public University(string universityName)
        {
            UniversityName = universityName;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("University Name: " + UniversityName);
            Console.WriteLine("Departments:");
            foreach (var department in Departments)
            {
                department.DisplayDetails();
            }
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    University university = new University("Tech University");

        //    Department dept1 = new Department("Computer Science");
        //    Department dept2 = new Department("Electrical Engineering");

        //    Faculty fac1 = new Faculty("Dr.Rambhag");
        //    Faculty fac2 = new Faculty("Dr.Atul ");

        //    dept1.AddFaculty(fac1);
        //    dept2.AddFaculty(fac2);

        //    university.AddDepartment(dept1);
        //    university.AddDepartment(dept2);

        //    university.DisplayDetails();

        //    university = null;

        //    fac1.DisplayDetails();
        //}
    }
}