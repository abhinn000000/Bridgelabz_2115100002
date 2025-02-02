using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Circle1
    {   //Attributes
        private double radius;

        //Constructors
        public Circle1(double radius)
        {
            this.radius = radius;
        }

        //Constructor chaining
        public Circle1() : this(1) 
        {
        
        }

        //Calculating area
        public double Area()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        //Calculating circumference
        public double Circumference()
        {
            double cir = 2 * Math.PI * radius;
            return cir;
        }

        //Displaying result
        public void DisplayResult()
        {
            Console.WriteLine("The area of the circle with the radius " + radius + "is " + Area());
            Console.WriteLine("The circumference of the circle with the radius " + radius + "is " + Circumference());
        }
    }
    public class program4
    {
        //public static void Main(String[] args) {
        //    Circle1 circle1 = new Circle1(5.6);
        //    Circle1 circle2 = new Circle1();
        //    circle1.DisplayResult();
        //    circle2.DisplayResult();

        //}


    }

}
