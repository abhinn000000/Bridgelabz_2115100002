using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Bubble
    {
        public static void BubbleSort()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < 10;i++) { //taking input
                int input = Convert.ToInt32(Console.ReadLine());
                arr[i] = input;
            }
            for (int i = 0; i < 9; i++) { //applying bubble sort
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0;i < 10;i++) { //printing the array
                Console.WriteLine(arr[i]);
            }
        }
    }

    class program {
        public static void Main(String[] args) {
            Bubble.BubbleSort();
        }
    }
}
