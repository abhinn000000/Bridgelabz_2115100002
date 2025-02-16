using System;
using System.Linq;

namespace MissingPositiveAndBinarySearch
{
    internal class SearchOperations
    {
        // Function to find the first missing positive integer using linear search
        public int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;

            // Mark numbers (by swapping) to their correct positions if possible
            for (int i = 0; i < n; i++)
            {
                while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
                {
                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                }
            }

            // Find the first index where the value is incorrect
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != i + 1)
                    return i + 1;
            }

            return n + 1;
        }

        // Function to perform binary search on a sorted array
        public int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SearchOperations searchOps = new SearchOperations();

            Console.WriteLine("Enter the list of integers separated by spaces:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Find the first missing positive integer
            int missingPositive = searchOps.FindFirstMissingPositive((int[])arr.Clone());
            Console.WriteLine("The first missing positive integer is: " + missingPositive);

            // Sort the array for binary search
            Array.Sort(arr);
            Console.WriteLine("Sorted array for Binary Search: " + string.Join(", ", arr));

            Console.WriteLine("Enter the target number to search:");
            int target = int.Parse(Console.ReadLine());

            int index = searchOps.BinarySearch(arr, target);

            if (index != -1)
                Console.WriteLine("Target found at index: " + index);
            else
                Console.WriteLine("Target not found.");
        }
    }
}
