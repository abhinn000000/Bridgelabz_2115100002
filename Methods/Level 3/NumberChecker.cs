using System;
using System.Linq;

public static class NumberChecker
{
    // a. Method to Find the count of digits in the number
    public static int GetDigitCount(int number)
    {
        return number.ToString().Length;
    }

    // b. Method to Store the digits of the number in a digits array
    public static int[] GetDigits(int number)
    {
        return number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    }

    // c. Method to Check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigits(number);
        return digits.Length > 1 && digits.Contains(0);
    }

    // d. Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = GetDigits(number);
        int power = digits.Length;
        int sum = digits.Sum(digit => (int)Math.Pow(digit, power));
        return sum == number;
    }

    // e. Method to find the largest and second largest elements in the digits array
    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return new int[] { largest, secondLargest };
    }

    // f. Method to find the smallest and second smallest elements in the digits array
    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return new int[] { smallest, secondSmallest };
    }

    // Main method
    public static void Main()
    {
        int number = 153;

        Console.WriteLine("Number: " + number);

        // a. Count of digits
        int count = GetDigitCount(number);
        Console.WriteLine("Digit Count: " + count);

        // b. Digits array
        int[] digits = GetDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // c. Check for Duck Number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuck);

        // d. Check for Armstrong Number
        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine("Is Armstrong Number: " + isArmstrong);

        // e. Largest and second largest
        int[] largestElements = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest: " + largestElements[0] + ", Second Largest: " + largestElements[1]);

        // f. Smallest and second smallest
        int[] smallestElements = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest: " + smallestElements[0] + ", Second Smallest: " + smallestElements[1]);
    }
}
