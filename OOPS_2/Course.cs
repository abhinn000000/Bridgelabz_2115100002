using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Course
    {
        //Attributes
        private string courseName;
        private int duration;
        private int fee;
        private static string instituteName = "Goals Classes";

        //Constructor
        public Course(string courseName, int duration, int fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        //Updating the instituteName
        public static void UpdateInstituteName()
        {
            Console.WriteLine("Enter the new Institute name ");
            string newInstituteName = Console.ReadLine();
            instituteName = newInstituteName;
        }

        //Displaying course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine("The name of the course is " + courseName);
            Console.WriteLine("The duration of the course is " + duration + " months ");
            Console.WriteLine("The fee of the course is " + fee);
            Console.WriteLine("The name of the institute is " + instituteName);
        }

        public class program9 {
            //public static void Main(String[] args)
            //{
            //    Course course1 = new Course("Machine Learning", 6, 10000);
            //    course1.DisplayCourseDetails();
            //    Course course2 = new Course("AI", 6, 10000);
            //    UpdateInstituteName();
            //    course1.DisplayCourseDetails();
            //    course2.DisplayCourseDetails();
            //}
        }
    }
}
