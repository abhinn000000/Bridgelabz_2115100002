using System;

public class NumberChecker5
{
    public static int[] FindFactors(int number)
    {
        int count = 0;
        // First loop to count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        // Second loop to store factors
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

    public static int FindGreatestFactor(int number)
    {
        int[] factors = FindFactors(number);
        return factors[factors.Length - 1];
    }

    public static int FindSumOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static long FindProductOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        long product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }

    public static double FindProductOfCubeFactors(int number)
    {
        int[] factors = FindFactors(number);
        double product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }
        return product;
    }

    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        // Sum all factors except the number itself
        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }
        return sum == number;
    }

    public static bool IsAbundantNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        // Sum all factors except the number itself
        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }
        return sum > number;
    }

    public static bool IsDeficientNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        // Sum all factors except the number itself
        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }
        return sum < number;
    }

    public static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sum = 0;
        
        while (number > 0)
        {
            int digit = number % 10;
            sum += CalculateFactorial(digit);
            number /= 10;
        }
        
        return sum == originalNumber;
    }

    private static int CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
            
        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public static void Main()
    {
        int testNumber = 28; // Example number for testing (28 is a perfect number)
        
        Console.WriteLine("Number Analysis for: " + testNumber);
        Console.WriteLine("-----------------------------");

        // Test FindFactors
        int[] factors = FindFactors(testNumber);
        Console.Write("Factors: ");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();

        // Test other methods
        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(testNumber));
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(testNumber));
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(testNumber));
        Console.WriteLine("Product of Cube Factors: " + FindProductOfCubeFactors(testNumber));
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(testNumber));
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(testNumber));
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(testNumber));
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(testNumber));
    }
}