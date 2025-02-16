using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    internal class BinarySmallest
    {
        public void binarySearch() {
            int[] arr = new int[7] {4, 5, 6, 7, 0, 1, 2};
            int left = 0;
            int right = arr.Length - 1;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (arr[left] == arr[mid]) {
                    Console.WriteLine("The index of the smallest number in the array is " + mid);
                }
                if (arr[right] < arr[mid])
                {
                    left = mid + 1;
                }
                else {
                    right = mid;
                }
            }
        }
    }

    class program5 {
        public static void Main(String[] args) {
            BinarySmallest binarySmallest = new BinarySmallest();
            binarySmallest.binarySearch();
        }
    }
}
