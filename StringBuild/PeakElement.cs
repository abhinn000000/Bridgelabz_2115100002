using System;

namespace PeakElementFinder
{
    internal class PeakElement
    {
        public int FindPeakElement(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid is smaller than next element
                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;  // Move towards the side of the larger element
                }
                else
                {
                    right = mid;  // Peak is on the left side
                }
            }

            return left;  // 'left' will be the peak index
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PeakElement peakElement = new PeakElement();

            Console.WriteLine("Enter the elements of the array separated by spaces:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int peakIndex = peakElement.FindPeakElement(arr);
            Console.WriteLine("A peak element is: " + arr[peakIndex] + " at index " + peakIndex);
        }
    }
}
