using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi_koji_nije_deljiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unosimo broj el prim niza
            int n = int.Parse(Console.ReadLine());
            // unosimo prim niz duzine n
            int[] arr = new int[n];
            // unosni string niz str
            string[] str = Console.ReadLine().Split();

            // mapiranje vrednosti iz unosnog string niza str u prim niz
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(str[i]);

            // citamo liniju
            string line;
            // proveravamo da li je linija prazna
            while ((line = Console.ReadLine()) != null)
            {
                // ako nije prazna
                // parsujemo liniju iz tipa string u tip int
                int k = int.Parse(line);
                // inicijalizujemo brojac rezultat
                int res = 0;
                // iteriramo n puta
                for (int i = 0; i < n; i++)
                    // proveravamo da li je vrednost iz niza arr sa pozicije i podeljena sa k ceo broj
                    if (arr[i] % k == 0)
                        // ako jeste povecavamo brojac rezultat
                        res++;
                // ispisujemo tu vrednost 
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}
