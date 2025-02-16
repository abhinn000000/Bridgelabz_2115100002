using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTry
{
    internal class Concatinate
    {
        public void ConcatinateStrings() {
            string[] arr = new string[] { "hi","I","am","Abhinn"};
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i < arr.Length;i++)
            {
                sb.Append(arr[i]);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
        }
    }

    class program2 {
        //public static void Main(String[] args)
        //{
        //    Concatinate object1 = new Concatinate();
        //    object1.ConcatinateStrings();
        //}
    }
}
