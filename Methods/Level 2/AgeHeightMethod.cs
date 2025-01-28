using System;

class AgeHeightMethod
{
    // Method to find the youngest person's age
    static int Youngest(int[] ages)
    {
        int minAge = ages[0];
        for (int i = 1; i < ages.Length; i++)
        {
            if (minAge > ages[i])
            {
                minAge = ages[i];
            }
        }
        return minAge;
    }

    // Method to find the tallest person's height
    static double Tallest(double[] heights)
    {
        double maxHeight = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (maxHeight < heights[i])
            {
                maxHeight = heights[i];
            }
        }
        return maxHeight;
    }

    public static void Main(string[] args)
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter Age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Height: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestAge = Youngest(ages);
        double tallestHeight = Tallest(heights);

        Console.WriteLine("The youngest one has the age " + youngestAge);
        Console.WriteLine("The tallest one has the height " + tallestHeight);
    }
}
