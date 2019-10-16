using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sinulle annetaan lukuja yksi kerrallaan, ja tehtäväsi on ilmoittaa jokaisen luvun kohdalla, montako lukua oli välissä ennen kuin sama luku esiintyi viimeksi aiemmin.

//Tee luokka Toistuminen, jossa on seuraavat metodit:

//int uusiLuku(int x): palauttaa välissä olleiden lukujen määrän (tai –1, jos luku esiintyy ensimmäistä kertaa)
//Rajat:

//jokainen luku on välillä 1...10^9
//metodia kutsutaan yhteensä enintään 10^6 kertaa
//Seuraava koodi esittelee luokan käyttämistä:

//Toistuminen t = new Toistuminen();
//System.out.println(t.uusiLuku(1)); // -1
//System.out.println(t.uusiLuku(2)); // -1
//System.out.println(t.uusiLuku(3)); // -1
//System.out.println(t.uusiLuku(1)); // 2
//System.out.println(t.uusiLuku(2)); // 2
//System.out.println(t.uusiLuku(1)); // 1

namespace W5_HashTable_E3
{
    public class Toistuminen
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        int i = 0;
        public int uusiLuku(int x)
        {
            i++;
            if (!d.ContainsKey(x))
            {
                d.Add(x, i);
                return -1;
            }
            else
            {
                var distance = i - 1 - d[x];
                d[x] = i;
                return distance;
            }
        }
    }

    class Program
    {
       static void Main(string[] args)
        {
            var t = new Toistuminen();
            Console.WriteLine(t.uusiLuku(1));
            Console.WriteLine(t.uusiLuku(2));
            Console.WriteLine(t.uusiLuku(3));
            Console.WriteLine(t.uusiLuku(1));
            Console.WriteLine(t.uusiLuku(2));
            Console.WriteLine(t.uusiLuku(1));
            Console.ReadKey();
       }
    }
}
