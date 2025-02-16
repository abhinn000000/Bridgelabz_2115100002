using System;
using System.Text;
using System.Diagnostics;

namespace StringPerformanceComparison
{
    internal class PerformanceTester
    {
        public void CompareStringPerformance(int iterations)
        {
            // Measuring time for string concatenation
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string str = "";
            for (int i = 0; i < iterations; i++)
            {
                str += "a";
            }

            stopwatch.Stop();
            Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");

            // Measuring time for StringBuilder
            stopwatch.Restart();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }

            stopwatch.Stop();
            Console.WriteLine("StringBuilder concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    PerformanceTester tester = new PerformanceTester();
        //    tester.CompareStringPerformance(100000);  // Run the performance comparison
        //}
    }
}
