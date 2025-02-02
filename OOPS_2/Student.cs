using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Student
    {
        //Attributes
        public int rollNumber;
        protected string name;
        private double CGPA;

        //Constructor
        public Student(int rollNumber, string name, double CGPA)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.CGPA = CGPA;
        }
        //Updating CGPA of a student
        public void updateCGPA()
        {
            Console.WriteLine("Enter the new CGPA");
            CGPA = Convert.ToDouble(Console.ReadLine());
        }

        //Displaying student details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The roll number of the student is " + rollNumber);
            Console.WriteLine("The name of the student is " + name);
            Console.WriteLine("The CGPA of the student is " + CGPA);
        }
    }

    class PostgraduateStudent : Student {
        public PostgraduateStudent(int rollNumber, string name, double CGPA) : base(rollNumber, name, CGPA) {
        
        }

        //Modifying the protected member directly in a subclass to show the functionality of protected member
        public void UpdateName() {
            Console.WriteLine("Enter the new name");
            name = Console.ReadLine();
        }

        public override void DisplayDetails() {
            base.DisplayDetails(); // accessing base class method for over riding
        }
    }

    class program11
    {
        //public static void Main(String[] args)
        //{
        //    Student student1 = new Student(2115100002, "Abhi", 9.1);
        //    student1.DisplayDetails();
        //    student1.updateCGPA();
        //    student1.DisplayDetails();

        //    PostgraduateStudent pg1 = new PostgraduateStudent(2115100001, "Akhil", 7.8);
        //    pg1.DisplayDetails();
        //    pg1.UpdateName();
        //    pg1.DisplayDetails();
        //}
    }

}
