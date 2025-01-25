using System;

class BMI
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of people:");
        int num = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[num][]; // Multi-dimensional array to store weight, height, and BMI
        string[] weightStatus = new string[num];  // Array to store weight status

        for (int i = 0; i < num; i++)
        {
            personData[i] = new double[3]; // Each person has 3 values: weight, height, and BMI

            Console.WriteLine("Enter the weight of person " + (i + 1) + " (positive value):");
            double weight = Convert.ToDouble(Console.ReadLine());
            while (weight <= 0)
            {
                Console.WriteLine("Weight must be a positive value. Please try again.");
                weight = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter the height of person " + (i + 1) + " (positive value in meters):");
            double height = Convert.ToDouble(Console.ReadLine());
            while (height <= 0)
            {
                Console.WriteLine("Height must be a positive value");
                height = Convert.ToDouble(Console.ReadLine());
            }

            personData[i][0] = weight; 
            personData[i][1] = height; 
            personData[i][2] = weight / height; 

            //weight status
            if (personData[i][2] < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i][2] < 25)
            {
                weightStatus[i] = "Normal";
            }
            else if (personData[i][2] < 30)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        // Display results

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Weight = " + personData[i][0] + " kg, Height = " + personData[i][1] + " m, BMI = " + personData[i][2].ToString("F2") + ", Weight Status = " + weightStatus[i]);
        }
    }
}
