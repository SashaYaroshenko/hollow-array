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
            //Kata.IsHollow(new int[] { 2, 0, 1, 0, 0, 0, 1, 0, 2 });
            Kata.IsHollow(new int[] { -1, 0, 0, 0, 0 });
        }
    }

    public class Kata
    {
        public static bool IsHollow(int[] x)
        {
            List<int> before = x.TakeWhile(c => c != 0).ToList();
            List<int> middle = x.Skip(before.Count).TakeWhile(c => c == 0).ToList();
            List<int> after = x.Skip(before.Count + middle.Count).ToList();

            if (middle.Count>=3)
            {
                if (before.Count == after.Count)
                {
                    bool a = after.All(c => c != 0);
                    if (a == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
