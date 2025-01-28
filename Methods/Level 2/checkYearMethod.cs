using System;

namespace LeapYearChecker
{
    class Program
    {
        static bool checkYear()
        {
            Console.WriteLine("Please enter a year (>= 1582):");
            int inputYear = int.Parse(Console.ReadLine());

            if (inputYear >= 1582)
            {
                if (inputYear % 100 == 0)
                {
                    if (inputYear % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (inputYear % 4 == 0)
                {
                    return true;
				}
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
		public static void Main(String [] args){
			bool result = checkYear();
			Console.WriteLine(result);
		}
    }
}
