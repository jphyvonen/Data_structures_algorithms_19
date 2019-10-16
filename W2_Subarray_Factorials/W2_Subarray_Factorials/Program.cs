using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_Subarray_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 4, 3, 2, 1 };
            int[] arr1 = new int[6] { 3, 2, 1, 2, 1, 3 };
            int[] arr2 = new int[5] { 1, 2, 1, 3, 2 };
            int[] arr3 = new int[5] { 1, 1, 1, 1, 1 };

            Console.WriteLine(laske(arr));
            Console.WriteLine(laske(arr1));
            Console.WriteLine(laske(arr2));
            Console.WriteLine(laske(arr3));
            Console.ReadKey();
            int laske(int[] t)
            {
                var summa = t.Length + t.Length - 1;

                int res = 0, cur = 0, count_b = 0, a = 0, b = 0;

                //longest consecutive subarray with only 2 distinct integers
                foreach (var c in t)
                {
                    cur = c == a || c == b ? cur + 1 : count_b + 1;
                    count_b = c == b ? count_b + 1 : 1;
                    if (b != c) { a = b; b = c; }
                    res = Math.Max(res, cur);
                }
                res = res - 2;
                for (int i = res; i >= 1; i--)
                {
                    summa = summa + i;
                }
                return summa;
            }
        }
    }
}
