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
            Kata.IsHollow(new int[] { -1, 0, 0, 0, 3 });
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
            if(index2-index1<3-2)
            {
                return false;
            }
            else
            {
                count1 = index1;
                count2 = (x.Length-1) - index2;
                if (count1 == count2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
