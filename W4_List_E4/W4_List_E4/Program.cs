using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Annettuna on taulukko, jossa on n kokonaislukua.Joka vuorolla poistat taulukosta kaksi vierekkäistä alkiota, jotka ovat samat, kunnes et voi enää poistaa mitään. Jos poiston voi tehdä monella tavalla, poistat alkiot mahdollisimman vasemmalta. Montako alkiota on lopullisessa taulukossa?

//Esimerkiksi jos taulukko on[1, 2, 2, 3, 3, 1], siitä tulee ensin[1, 3, 3, 1], sitten[1, 1] ja lopuksi[], eli tässä tapauksessa taulukossa ei ole yhtään alkiota lopuksi.

//Tee luokka Poistot, jossa on seuraavat metodit:

//int laske(int[] t): palauttaa lopullisen taulukon alkioiden määrän
//Rajat:

//1 ≤ n ≤ 106
//jokainen alkio on välillä 1...109
//Seuraava koodi esittelee luokan käyttämistä:

//Poistot p = new Poistot();
//System.out.println(p.laske(new int[] {1,2,2,3})); // 2
//System.out.println(p.laske(new int[] {1,2,3,4})); // 4
//System.out.println(p.laske(new int[] {1,2,2,3,3,1})); // 0
namespace W4_List_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 2, 3, 1, 1 }; // 2
            var arr2 = new int[] { 1, 2, 3, 4 }; // 4
            var arr3 = new int[] { 3, 1, 1, 1, 2, 2, 3, 3, 3, 1, 3 }; //5
            var arr4 = new int[] { 1, 1, 2, 2, 3, 3, 1, 2 }; // 2
            var arr5 = new int[] { 1, 3, 3, 4, 4, 1, 2, 5, 5, 2 }; // 0
            var arr6 = new int[] { 1, 2, 1, 2 };
            var arr8 = new int[] { 1, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 1, 2, 1, 1, 1, 1, 2, 2, 1 };
            //                     2  1  0  0  0  0  0  0  0  0  1  2     0  0  0  0  0  0
            var arr7 = new int[1000000];
            Random random = new Random(1337);
            var sep = 0;
            foreach (var i in arr7)
            {
                arr7[sep] = random.Next(2) + 1;
                sep++;
            }
            //Console.WriteLine(laske(arr));
            //Console.WriteLine(laske(arr2));
            //Console.WriteLine(laske(arr3));
            //Console.WriteLine(laske(arr4));
            //Console.WriteLine(laske(arr5));
            //Console.WriteLine(laske(arr6));
            Console.WriteLine(laske(arr8));
            Console.ReadKey();
            int laske(int[] t)
            {
                if (t.Length == 1) return 1;
                bool jatka = false;
                int[] apu = new int[t.Length];
                int[] u = new int[0];
                int kohta = 0;
                for (int i = 0; i < t.Length - 1; i++)
                {
                    if (t[i] != 0 && t[i + 1] != 0 && t[i] == t[i + 1])
                    {
                        t[i] = 0;
                        t[i + 1] = 0;
                        jatka = true;
                    }
                    if (t[i] != 0)
                    {
                        apu[kohta] = t[i];
                        kohta++;
                    }
                    if (i == t.Length - 2 && t[i + 1] != 0)
                    {
                        apu[kohta] = t[i + 1];
                        kohta++;
                    }
                }
                if (!jatka) return t.Length;
                u = new int[kohta];
                for (int i = 0; i < u.Length; i++)
                {
                    u[i] = apu[i];
                }
                return laske(u);
            }
        }

    }
}
