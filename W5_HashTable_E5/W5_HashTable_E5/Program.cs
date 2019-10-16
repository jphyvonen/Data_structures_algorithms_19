using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_HashTable_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            string ss = "aaabbbbbbbababbbba";
            string sss = "aabaaabbabaabaaaaa";

            string t1 = "";
            string t2 = "";
            var arr = new char[] { 'a', 'b' };
            //tulostaMerkkijonoja(arr,"", 2, 18);
            Console.WriteLine(ss.GetHashCode() + "   " + sss.GetHashCode());
            Console.ReadKey();
            void tulostaMerkkijonoja(char[] merkit, String etu, int n, int k)
            {
                if (k == 0)
                {
                    if (d.Keys.Contains(etu.GetHashCode()))
                    {
                        Console.WriteLine("törmää: "+ d[etu.GetHashCode()] +" ja " +  etu);
                    }
                    else
                        d.Add(etu.GetHashCode(), etu);
                    return;
                }
                for (int i = 0; i < n; ++i)
                {
                    String newPrefix = etu + merkit[i];
                    tulostaMerkkijonoja(merkit, newPrefix,
                                            n, k - 1);
                }
            }
        }
    }
}
