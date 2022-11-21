using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unos broj el u prim nizu
            int n = int.Parse(Console.ReadLine());
            // prim niz duzine n
            int[] arr = new int[n];
            // unosni string niz
            string[] str = Console.ReadLine().Split();
            // mapiranje vrednosti iz string niza u prim niz
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(str[i]);

            // var xor
            int xor = int.Parse(Console.ReadLine());
            // brojac res koji povecavamo
            int res = 0;

            // ponavljanej za svaki el niza sa svakim bez ponavljanja
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    // vrednost sa pozicije i i vrednost sa pozicije j 
                    // se poredi i gleda da li je jednako xor vrednsoti
                    // pa ako jeste povecava
                    if ((arr[i] ^ arr[j]) == xor)
                        res++;

            // ispisivanje res promenljive
            Console.WriteLine(res);
            Console.ReadKey(); 
        }
    }
}
