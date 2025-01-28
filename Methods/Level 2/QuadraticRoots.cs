using System;

class QuadraticRoots
{
    // Method to calculate roots
    static double[] FindRoots(int a, int b, int c)
    {
        double delta = (b * b) - 4 * a * c;
        double[] roots;

        if (delta > 0)
        {
            roots = new double[2];
            roots[0] = (-b + Math.Sqrt(delta)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(delta)) / (2 * a);
        }
        else if (delta == 0)
        {
            roots = new double[1];
            roots[0] = -b / (2.0 * a);
        }
        else
        {
            // Return an empty array if delta is negative
            roots = new double[0];
        }

        return roots;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a:");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value of b:");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value of c:");
        int c = Convert.ToInt32(Console.ReadLine());

        double[] results = FindRoots(a, b, c);

        if (results.Length == 0)
        {
            Console.WriteLine("No real roots exist (Delta is negative).");
        }
        else
        {
            Console.WriteLine("The roots are:");
            foreach (double root in results)
            {
                Console.WriteLine(root);
            }
        }
    }
}
