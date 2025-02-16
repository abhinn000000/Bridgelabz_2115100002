using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    internal class RemoveDuplicates
    {
        public void RemoveDuplicate() {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            HashSet<char> map = new HashSet<char>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in input) {
                if (!map.Contains(c))
                {
                    map.Add(c);
                    sb.Append(c);
                }
            }
            Console.WriteLine(sb.ToString());
            }
        }
    //class program1 {
    //    public static void Main(String[] args) {
    //        RemoveDuplicates rm = new RemoveDuplicates();
    //        rm.RemoveDuplicate();
    //    }
    //}
    }

