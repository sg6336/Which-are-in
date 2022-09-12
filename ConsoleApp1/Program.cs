using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            WhichAreIn.inArray(a1, a2);
        }
    }

    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            string str = String.Join(" ", array2);
            foreach (string item in array1)
            {
                if (str.Contains(item) == true)
                {
                    result.Add(item);
                }
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
