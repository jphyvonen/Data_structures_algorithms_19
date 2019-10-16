using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sinulla on 109 hattua, jotka on numeroitu 1, 2, ..., 109. Aluksi jokainen hattu on tyhjä, mutta sitten niihin aletaan lisätä palloja.

//Tee luokka HatutJaPallot, jossa on seuraavat metodit:

//void lisaaPallo(int x): lisää pallon hattuun x
//int monessakoYksi(): palauttaa, monessako hatussa on ainakin yksi pallo
//int suurinMaara(): palauttaa, mikä on suurin pallojen määrä yhdessä hatussa
//Rajat:

//1 ≤ x ≤ 109
//jokaisessa testissä metodeita kutsutaan yhteensä enintään 106 kertaa
//Seuraava koodi esittelee luokan käyttämistä:

//HatutJaPallot h = new HatutJaPallot();
//h.lisaaPallo(2);
//h.lisaaPallo(3);
//h.lisaaPallo(5);
//System.out.println(h.monessakoYksi()); // 3
//System.out.println(h.suurinMaara()); // 1
//h.lisaaPallo(3);
//System.out.println(h.monessakoYksi()); // 3
//System.out.println(h.suurinMaara()); // 2
namespace W5_HashTable_E2
{
    public class hatutJaPallot
    {
        public hatutJaPallot()
        {

        }
        readonly Dictionary<int, int> dic = new Dictionary<int, int>();
        public void lisaaPallo(int p)
        {
            if (!dic.ContainsKey(p))
                dic.Add(p, 1);
            else
                dic[p]++;
        }
        public int monessakoYksi()
        {
            return dic.Count;
        }
        public int suurinMaara()
        {
            var suurin = 0;
            foreach (var i in dic)
            {
                if (i.Value > suurin)
                    suurin = i.Value;
            }
            return suurin;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var hp = new hatutJaPallot();
            hp.lisaaPallo(2);
            hp.lisaaPallo(3);
            hp.lisaaPallo(5);
            Console.WriteLine("monessako: " + hp.monessakoYksi());
            Console.WriteLine("suurin: " + hp.suurinMaara());
            hp.lisaaPallo(3);
            Console.WriteLine("monessako: " + hp.monessakoYksi());
            Console.WriteLine("suurin: " + hp.suurinMaara());
            Console.ReadKey();
        }
    }
}
