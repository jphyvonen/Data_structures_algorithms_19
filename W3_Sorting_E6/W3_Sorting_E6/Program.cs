using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtäväsi on muodostaa n-kokoinen taulukko, joka sisältää luvut 1...n ja siinä on tasan k inversiota. Voit muodostaa minkä tahansa taulukon, joka täyttää nämä vaatimukset.
//Tee luokka Inversiot, jossa on seuraavat metodit:
//int[] muodosta(int n, long k): palauttaa taulukon
//Rajat:
//1 ≤ n ≤ 106
//k on valittu niin, että ratkaisu on olemassa
//Seuraava koodi esittelee luokan käyttämistä:
//Inversiot i = new Inversiot();
//int[] t = i.muodosta(5, 2);

namespace W3_Sorting_E6
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in laske(5, 2))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            //Ensimmäinen toteutus. Toimii, mutta liian hidas kurssin 1s rajalle isoilla 10^6 syötteillä.
            int[] laske(int n, int k)
            {
                int[] arr = new int[n];
                int[] pal = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = i + 1;
                }
                int raja = 0;
                int j = n - 1;
                for (int i = 0; i < k; i++)
                {
                    int swap = arr[j - 1]; arr[j - 1] = arr[j]; arr[j] = swap;
                    j--;
                    if (j == raja)
                    {
                        j = n - 1;
                        raja++;
                    }
                }
                return arr;
            }
            //Toinen toteutus alittaa 1s rajan.
            int[] laske2(int n, int k)
            {
                int[] arr = new int[n];
                int jaljella = k;
                int maks = n - 1;
                int pudotaLoppu = n;
                int pudotaAlku = 1;
                for (int i = 0; i < n; i++)
                {
                    if (jaljella >= maks)
                    {
                        arr[i] = pudotaLoppu;
                        pudotaLoppu--;
                        jaljella = jaljella - maks;
                    }
                    else
                    {
                        arr[i] = pudotaAlku;
                        pudotaAlku++;
                    }
                    maks = n - (i + 2);
                }
                return arr;
            }
        }
    }
}
