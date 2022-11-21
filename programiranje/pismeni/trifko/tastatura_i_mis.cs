using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tastatura_i_mis
{
    internal class Program
    {
        // funkcija za unos niza
        static int[] UnosNiza()
        {
            // unosimo n broj el prim niza 
            int n = int.Parse(Console.ReadLine());
            // prim niz duzine n 
            int[] arr = new int[n];
            // unosni string niz 
            string[] str = Console.ReadLine().Split();
            // mapiraneje vrednosti iz unosnog string niza i primarnog niza 
            for(int i = 0; i < n; i++)
                arr[i] = int.Parse(str[i]);
            // vracamo niz tipa int
            return arr;
        }
        static void Main(string[] args)
        {
            // funkcijom unosNiza() unosimo dva niza arrT i arrM
            int[] arrT = UnosNiza();
            int[] arrM = UnosNiza();

            // unosimo promeljivu novac
            int novac = int.Parse(Console.ReadLine());

            // unosimo promeljivu rezultat koju na kraju ispisujemo
            int rez = 0;

            // inicijalizujemo t sa vrednoscu duzine niza arrT i j sa vrednoscu 0
            int t = arrT.Length, j = 0;
            // ponavljamo dok su j i t razlicite vrednost
            while(j != t)
            {
                // ponavljamo onoliko puta kolika je duzina niza arrM
                for(int i = 0; i < arrM.Length; i++)
                {
                    // inicijalizujemo rezR kao zbir vrednosti iz arrM niza na poziciji i 
                    // i vrednosti iz niza arrT sa pozicije j
                    int rezR = arrM[i] + arrT[j];

                    // ako je rezR vece od rez i rezR <= vrednosti novac
                    if (rezR > rez && rezR <= novac)
                        // vrednost od rezR stavljamo u rez
                        rez = rezR;
                }
                // povecavamo j
                j++;
            }

            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
