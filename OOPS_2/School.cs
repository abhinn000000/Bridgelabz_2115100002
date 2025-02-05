using System;
using System.Collections.Generic;
namespace SchoolManagement
{
    class Course
    {
        public string CourseName { get; set; }
        private List<Student> EnrolledStudents { get; set; }

        public Course(string courseName)
        {
            CourseName = courseName;
            EnrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            EnrolledStudents.Add(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Students enrolled in " + CourseName + ":");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
    class Student
    {
        public string StudentName { get; set; }
        private List<Course> EnrolledCourses { get; set; }

        public Student(string studentName)
        {
            StudentName = studentName;
            EnrolledCourses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            EnrolledCourses.Add(course);
            course.EnrollStudent(this);
        }

        public void DisplayCourses()
        {
            Console.WriteLine(StudentName + " is enrolled in the following courses:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
    class School
    {
        public string SchoolName { get; set; }
        private List<Student> Students { get; set; }

        public School(string schoolName)
        {
            SchoolName = schoolName;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Students in " + SchoolName + ":");
            foreach (var student in Students)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    School school = new School("Apeejay High");
        //    Student student1 = new Student("Arvind");
        //    Student student2 = new Student("Catherine");
        //    Course course1 = new Course("Physics");
        //    Course course2 = new Course("Chemistry");
        //    school.AddStudent(student1);
        //    school.AddStudent(student2);
        //    student1.EnrollInCourse(course1);
        //    student1.EnrollInCourse(course2);
        //    student2.EnrollInCourse(course2);
        //    school.DisplayStudents();
        //    student1.DisplayCourses();
        //    student2.DisplayCourses();
        //    course1.DisplayStudents();
        //    course2.DisplayStudents();
        //}
    }
}