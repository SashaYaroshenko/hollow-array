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
            Kata.IsHollow(new int[] { 2, 0, 1, 0, 0, 0, 1, 0, 2 });
        }
    }

    public class Kata
    {
        public static bool IsHollow(int[] x)
        {
            int index1 = Array.IndexOf(x, 0);
            int index2 = Array.LastIndexOf(x, 0);

            int count1 = 0;
            int count2 = 0;
            int len = x.Length;

            while (x[index1] != 0 || x[index1 + 1] != 0 || x[index1 + 2] != 0)
            {
                if (index1 + 2 > index2)
                {
                    return false;
                }
                index1 = Array.IndexOf(x, 0, index1 + 1);
            }

            while (x[index2] != 0 || x[index2 - 1] != 0 || x[index2 - 2] != 0)
            {
                if (index1 + 2 > index2)
                {
                    return false;
                }
                index2 = Array.LastIndexOf(x, 0, index2 - 1);                
            }

            return true;
        }
    }
}
