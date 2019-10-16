using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Piirissä on n lasta, jotka on numeroitu 1, 2, 3, jne.Vuoro kiertää piirissä ja joka toinen lapsi poistuu piiristä, kunnes piirissä on vain yksi lapsi.Mikä on tämän lapsen numero?


//Esimerkiksi jos n on 7, lapset poistuvat piiristä järjestyksessä 2, 4, 6, 1, 5, 3, 7, eli viimeisenä piirissä on lapsi, jonka numero on 7.


//Tee luokka Piirileikki, jossa on seuraaat metodit:


//int viimeinen(int n): palauttaa viimeisen lapsen numeron
//Rajat:

//1 ≤ n ≤ 106
//Seuraava koodi esittelee luokan käyttämistä:


//Piirileikki p = new Piirileikki();
//System.out.println(p.viimeinen(7)); // 7
//System.out.println(p.viimeinen(4)); // 1
//System.out.println(p.viimeinen(123)); // 119
namespace W4_List_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(viimeinen(123));
            Console.ReadKey();
            int viimeinen(int n)
            {
                int k = 1;
                var list = new List<int>();
                for (int i = 1; i <= n; i++)
                {
                    list.Add(i);
                }
                for (int i = 0; i < list.Count - 1; i += 2)
                {
                    list.Add(list[i]);
                }
                return list[list.Count - 1];
            }
        }
    }
}
