using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Person
    {
        //Attributes
        private string name;
        private int age;

        //Constructor
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        //Copy Constructor
        public Person(Person person) {
            name = person.name;
            age = person.age;

        }

        //Display result
        public void DisplayResult()
        {
            Console.WriteLine("The name of the person is " + name);
            Console.WriteLine("The age of the person is " + age);
        }
    }

    class program5 {
        //public static void Main(String[] args)
        //{
        //    Person person1 = new Person("Abhi", 22);
        //    person1.DisplayResult();
        //    Person person2 = new Person(person1);
        //    person2.DisplayResult();
        //}
    }
}
