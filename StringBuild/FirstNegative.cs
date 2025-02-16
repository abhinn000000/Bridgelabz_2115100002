using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    internal class FirstNegative
    {
        public void fistNegative() {
            Console.WriteLine("Enter the integers");
            int[] arr = new int[10];
            int flag = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                arr[i] = input;
            }

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 0)
                {
                    Console.WriteLine("The first negative number in the array is " + arr[i]);
                    flag = 1; 
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("There are no negative numbers in the array");
            }

        }
    }

    class program3{
        //public static void Main(String[] args) {
        //    FirstNegative fn = new FirstNegative();
        //    fn.fistNegative();

        //}
    }
}
