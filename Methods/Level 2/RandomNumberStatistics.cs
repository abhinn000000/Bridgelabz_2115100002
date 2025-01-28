using System;
using System.Linq;

class RandomNumberStatistics
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // Generates numbers from 1000 to 9999
        }
        return randomNumbers;
    }

    // Method to find average, min, and max values of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        double average = numbers.Average();

        return new double[] { average, min, max };
    }

    static void Main(string[] args)
    {
        RandomNumberStatistics stats = new RandomNumberStatistics();

        // Generate 5 random numbers
        int[] randomNumbers = stats.Generate4DigitRandomArray(5);
        Console.WriteLine("Generated Numbers: " + string.Join(", ", randomNumbers));

        // Calculate average, min, and max
        double[] results = stats.FindAverageMinMax(randomNumbers);
        Console.WriteLine("Average: " + results[0].ToString("F2") + ", Min: " + results[1] + ", Max: " + results[2]);
    }
}
