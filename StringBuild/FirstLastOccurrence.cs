using System;

namespace SortedArraySearch
{
    internal class OccurrenceFinder
    {
        public int FindFirstOccurrence(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    right = mid - 1;  // Move left to find first occurrence
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        public int FindLastOccurrence(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    left = mid + 1;  // Move right to find last occurrence
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OccurrenceFinder finder = new OccurrenceFinder();

            Console.WriteLine("Enter the sorted array elements separated by spaces:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Enter the target element:");
            int target = int.Parse(Console.ReadLine());

            int first = finder.FindFirstOccurrence(arr, target);
            int last = finder.FindLastOccurrence(arr, target);

            if (first == -1)
            {
                Console.WriteLine("Element not found in the array.");
            }
            else
            {
                Console.WriteLine("First occurrence at index: " + first);
                Console.WriteLine("Last occurrence at index: " + last);
            }
        }
    }
}
