using System;

namespace MatrixBinarySearch
{
    internal class MatrixSearch
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = matrix[mid / cols, mid % cols];  // Get the element at mid index

                if (midValue == target)
                {
                    return true;  // Target found
                }
                else if (midValue < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;  // Target not found
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixSearch matrixSearch = new MatrixSearch();

            int[,] matrix = {
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50}
            };

            Console.WriteLine("Enter the target value to search:");
            int target = int.Parse(Console.ReadLine());

            bool found = matrixSearch.SearchMatrix(matrix, target);

            if (found)
            {
                Console.WriteLine("Target found in the matrix.");
            }
            else
            {
                Console.WriteLine("Target not found.");
            }
        }
    }
}
