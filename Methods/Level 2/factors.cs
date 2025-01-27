using System;

class Factors
{
    // Method to find the factors and return them as an array
    static int[] fact(int number)
    {
        int count = 0;

        // Count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Create an array to store factors
        int[] factors = new int[count];
        int index = 0;

        // Store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to find the sum of factors
    static int factSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of factors
    static int factProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the sum of the squares of the factors
    static int squareSum(int[] factors)
    {
        int sumSquare = 0;
        foreach (int factor in factors)
        {
            sumSquare += factor * factor;
        }
        return sumSquare;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());

        // Get factors
        int[] factors = fact(input);

        // Calculate results
        int sum = factSum(factors);
        int sumSquare = squareSum(factors);
        int product = factProduct(factors);

        // Display the factors
        Console.WriteLine("The factors are:");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Display the results
        Console.WriteLine("The sum of the factors is: " + sum);
        Console.WriteLine("The sum of the squares of the factors is: " + sumSquare);
        Console.WriteLine("The product of the factors is: " + product);
    }
}
