using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tien varrella on n taloa, joista jokaisella on tietty sijainti(kohta x - akselilla).
//Tehtäväsi on rakentaa tielle bussipysäkkejä niin, että jokaisen talon etäisyys lähimpään pysäkkiin on enintään k.Mikä on pienin mahdollinen määrä pysäkkejä?
//Tee luokka Pysakit, jossa on seuraavat metodit:
//int laske(int[] t, int k): palauttaa pienimmän pysäkkien määrän
//Rajat:
//1 ≤ n ≤ 106
//jokainen talon sijainti on välillä 1...109
//1 ≤ k ≤ 109
//Seuraava koodi esittelee luokan käyttämistä:
//            Pysakit p = new Pysakit();
//            System.out.println(p.laske(new int[] { 3, 7, 1, 5 }, 1)); // 2
//            System.out.println(p.laske(new int[] { 3, 7, 1, 5 }, 2)); // 2
//            System.out.println(p.laske(new int[] { 3, 7, 1, 5 }, 3)); // 1


namespace W3_Sorting_E3
{
    class Program
    {

        static void Main(string[] args)
        {
            var arr = new int[4] { 1, 3, 5, 7 };
            var arr1 = new int[4] { 1, 3, 5, 7 };
            Console.WriteLine(laske(arr, 1));
            Console.WriteLine(laske(arr, 2));
            Console.WriteLine(laske(arr, 3));
            Console.ReadKey();
            int laske(int[] t, int k)
            {
                int n = t.Length;
                int pysakit = 1;
                int pysakinPaikka = t[0] + k;
                Array.Sort(t);
                for (int i = 0; i < n; i++)
                {
                    if (t[i] - pysakinPaikka > k)
                    {
                        pysakit++;
                        pysakinPaikka = t[i] + k;
                    }
                }
                return pysakit;
            }
        }
    }
}
