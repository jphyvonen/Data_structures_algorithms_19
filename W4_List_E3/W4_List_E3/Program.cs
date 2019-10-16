using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtäväsi on toteuttaa listarakenne, jossa pystyy lisäämään tehokkaasti alkion listan alkuun ja loppuun sekä hakemaan annetussa kohdassa olevan alkion.

//Lista on alussa tyhjä.Kun siihen lisätään alkioita, ne numeroidaan 0, 1, 2, jne.listan alusta alkaen.

//Tee luokka Lista, jossa on seuraavat metodit:

//void lisaaAlkuun(int x): lisää alkion x listan alkuun
//void lisaaLoppuun(int x): lisää alkion x listan loppuun
//int haeAlkio(int k): palauttaa kohdassa k olevan alkion
//Rajat:

//1 ≤ x ≤ 109
//k osoittaa johonkin listan kohtaan
//jokaisessa testissä metodeita kutsutaan yhteensä enintään 106 kertaa
//Seuraava koodi esittelee luokan käyttämistä:

//Lista l = new Lista();
//l.lisaaLoppuun(3);
//l.lisaaLoppuun(5);
//System.out.println(l.haeAlkio(1)); // 5
//l.lisaaAlkuun(2);
//System.out.println(l.haeAlkio(1)); // 3
namespace W4_List_E3
{
    public class OmaLista
    {
        private int n;
        private int[] t;
        int kac;
        int klc;
        int ka;
        int kl;
        public OmaLista()
        {
            n = 1000000;
            t = new int[n];
            ka = n - 1;
            kl = 0;
        }
        public void lisaaAlkuun(int a)
        {
            if (kac == 0)
            {
                t[ka] = a;
                kac++;
                return;
            }
            ka--;
            t[ka] = a;
            kac++;
        }
        public int haeAlkio(int a)
        {
            if (a > (kac - 1))
            {
                return t[a - kac];
            }
            else
            {
                return t[ka + a];
            }
        }
        public void lisaaLoppuun(int a)
        {
            if (klc == 0)
            {
                t[kl] = a;
                klc++;
                return;
            }
            kl++;
            t[kl] = a;
            klc++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new OmaLista();
            lista.lisaaAlkuun(5);
            lista.lisaaAlkuun(5);
            lista.lisaaAlkuun(5);
            lista.lisaaAlkuun(5);
            lista.lisaaLoppuun(234);
            lista.lisaaLoppuun(234);
            lista.lisaaLoppuun(234);
            lista.lisaaLoppuun(234);
            lista.lisaaLoppuun(234);
            lista.lisaaLoppuun(234);
            lista.lisaaAlkuun(12);
            Console.WriteLine(lista.haeAlkio(10));
            Console.ReadKey();
        }
    }
}
