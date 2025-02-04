using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{       //Attributes
    internal class Student1
    {
        private static string UniversityName = "GLA";
        private static int totalStudents = 0;
        private string Name;
        private readonly int RollNumber;
        private string Grade;

        //Constructor
        public Student1(string Name, int RollNumber, string Grade)
        {
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;
            totalStudents++;
        }

        //getting total employees
        public int GetTotalEmployees()
        {
            return totalStudents;
        }

        public static void getUniName() {
            Console.WriteLine("The name of the university is " + UniversityName);
        }

        //displaying details
        public void DisplayDetails()
        {
            if (this is Student1)
            {
                Console.WriteLine("The total number of students is " + GetTotalEmployees());
                Console.WriteLine("The name of the student is " + Name);
                Console.WriteLine("The Roll Number of the student is " + RollNumber);
                Console.WriteLine("The Grade of the student is " + Grade);
            }
        }

    }

    class program19
    {
        //public static void Main(String[] args)
        //{
        //    Student1.getUniName();
        //    Student1 student1 = new Student1("Ashish", 789, "A+");
        //    student1.DisplayDetails();
        //    Student1 student2 = new Student1("Ashwinder", 790, "B-");
        //    student2.DisplayDetails();

        //}
    }
}
