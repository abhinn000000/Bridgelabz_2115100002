using System;

class BMI2dMethod
{
    // Function to calculate BMI for each person
    static void calculateBMI(double[,] arr)
    {
        for (int j = 0; j < 10; j++)
        {
            arr[2, j] = arr[0, j] / (arr[1, j] * arr[1, j]);
        }
    }

    // Function to display weights, heights, BMIs, and statuses
    static void displayResults(double[,] arr)
    {
        Console.WriteLine("Person\tWeight(kg)\tHeight(m)\tBMI\t\tStatus");

        for (int i = 0; i < 10; i++)
        {
            string status;

            if (arr[2, i] <= 18.4)
            {
                status = "Underweight";
            }
            else if (arr[2, i] >= 18.5 && arr[2, i] <= 24.9)
            {
                status = "Normal";
            }
            else if (arr[2, i] >= 25.0 && arr[2, i] <= 39.9)
            {
                status = "Overweight";
            }
            else
            {
                status = "Obese";
            }

            Console.WriteLine(i + 1 + "\t" + arr[0, i] + "\t\t" + arr[1, i] + "\t\t" + arr[2, i].ToString("F2") + "\t\t" + status);
        }
    }

    public static void Main(string[] args)
    {
        double[,] arr = new double[3, 10];

        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("Enter the weight for person " + (j + 1) + " (in kg):");
            arr[0, j] = Convert.ToDouble(Console.ReadLine());
        }

        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("Enter the height for person " + (j + 1) + " (in cm):");
            arr[1, j] = Convert.ToDouble(Console.ReadLine()) / 100; // cm to meters
        }

        calculateBMI(arr);
        displayResults(arr);
    }
}
