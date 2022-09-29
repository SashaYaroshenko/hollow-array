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
            int index1 = 0;
            int index2 = 0;
            bool flag = false;
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    index1 = i;
                    break;
                }    
            }   
            for(int i=x.Length-1; i>=0; i--)
            {
                if (x[i] == 0)
                {
                    index2 = i;
                    break;
                }   
            }
            for(int i=0; i<x.Length; i++)
            {
                while(index1!=i)
                {
                    count1++;
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                while (index2 != i)
                {
                    count2++;
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                if (x[0] != 0 && x[x.Length - 1] != 0 && count1==count2)
                {
                    flag = true;
                }
                

            }
            return flag;
        }
    }
}
