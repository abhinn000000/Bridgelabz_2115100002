using System;

public static class NumberChecker2
{
    // a. Method to Find the count of digits in the number
    public static int GetDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // a. Method to Store the digits of the number in a digits array
    public static int[] GetDigits(int number)
    {
        int count = GetDigitCount(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // b. Method to find the sum of the digits of a number
    public static int GetSumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // c. Method to find the sum of the squares of the digits of a number
    public static int GetSumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    // d. Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number)
    {
        int[] digits = GetDigits(number);
        int sumOfDigits = GetSumOfDigits(digits);
        return sumOfDigits != 0 && number % sumOfDigits == 0;
    }

    // e. Method to find the frequency of each digit in the number
    public static int[,] GetDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // digit
            frequency[i, 1] = 0; // initialize frequency
        }
        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }
        return frequency;
    }

    // Main method to demonstrate the utility
    public static void Main()
    {
        int number = 153;

        Console.WriteLine("Number: " + number);

        // a. Count of digits
        int count = GetDigitCount(number);
        Console.WriteLine("Digit Count: " + count);

        // a. Digits array
        int[] digits = GetDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // b. Sum of digits
        int sumOfDigits = GetSumOfDigits(digits);
        Console.WriteLine("Sum of Digits: " + sumOfDigits);

        // c. Sum of squares of digits
        int sumOfSquares = GetSumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of Squares of Digits: " + sumOfSquares);

        // d. Check for Harshad Number
        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine("Is Harshad Number: " + isHarshad);

        // e. Frequency of each digit
        int[,] frequency = GetDigitFrequency(digits);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine("Digit: " + frequency[i, 0] + ", Frequency: " + frequency[i, 1]);
            }
        }
    }
}
