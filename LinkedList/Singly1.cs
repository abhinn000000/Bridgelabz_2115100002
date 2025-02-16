using System;

namespace StudentRecords
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public Student Next { get; set; }

        public Student(int rollNumber, string name, int age, string grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }

        public override string ToString()
        {
            return $"Roll Number: {RollNumber}, Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    class StudentLinkedList
    {
        private Student head;

        public StudentLinkedList()
        {
            head = null;
        }

        // Add a new student record at the beginning
        public void AddAtBeginning(Student newStudent)
        {
            newStudent.Next = head;
            head = newStudent;
        }

        // Add a new student record at the end
        public void AddAtEnd(Student newStudent)
        {
            if (head == null)
            {
                head = newStudent;
                return;
            }

            Student current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newStudent;
        }

        // Add a new student record at a specific position
        public void AddAtPosition(Student newStudent, int position)
        {
            if (position == 1)
            {
                AddAtBeginning(newStudent);
                return;
            }

            Student current = head;
            int count = 1;
            while (current != null && count < position - 1)
            {
                current = current.Next;
                count++;
            }

            if (current == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            newStudent.Next = current.Next;
            current.Next = newStudent;
        }

        // Delete a student record by Roll Number
        public void DeleteByRollNumber(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.RollNumber == rollNumber)
            {
                head = head.Next;
                return;
            }

            Student current = head;
            while (current.Next != null && current.Next.RollNumber != rollNumber)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            current.Next = current.Next.Next;
        }

        // Search for a student record by Roll Number
        public Student SearchByRollNumber(int rollNumber)
        {
            Student current = head;
            while (current != null)
            {
                if (current.RollNumber == rollNumber)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Display all student records
        public void DisplayAll()
        {
            Student current = head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }

        // Update a student's grade based on their Roll Number
        public void UpdateGrade(int rollNumber, string newGrade)
        {
            Student student = SearchByRollNumber(rollNumber);
            if (student != null)
            {
                student.Grade = newGrade;
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StudentLinkedList studentList = new StudentLinkedList();

            studentList.AddAtEnd(new Student(1, "Alice", 20, "A"));
            studentList.AddAtEnd(new Student(2, "Bob", 21, "B"));
            studentList.AddAtEnd(new Student(3, "Charlie", 22, "C"));

            Console.WriteLine("All Student Records:");
            studentList.DisplayAll();
            Console.WriteLine();

            Console.WriteLine("Searching for student with Roll Number 2:");
            Student student = studentList.SearchByRollNumber(2);
            if (student != null)
            {
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            Console.WriteLine();

            Console.WriteLine("Updating grade for student with Roll Number 2:");
            studentList.UpdateGrade(2, "A+");
            studentList.DisplayAll();
            Console.WriteLine();

            Console.WriteLine("Deleting student with Roll Number 1:");
            studentList.DeleteByRollNumber(1);
            studentList.DisplayAll();
            Console.WriteLine();

            Console.WriteLine("Adding student at the beginning:");
            studentList.AddAtBeginning(new Student(4, "Dave", 23, "B+"));
            studentList.DisplayAll();
            Console.WriteLine();
        }
    }
}