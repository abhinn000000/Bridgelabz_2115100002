using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Circle
    {   //Attributes
        private double radius;

        //Constructors
        public Circle(double radius)
        {
            this.radius = radius;
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
    public class program1 {
        /*public static void Main(String[] args) {
            Circle circle1 = new Circle(5.6);
            circle1.DisplayResult();

        }*/

        
    }

}
