using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cik_cak_selekcija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // broj elemenata
            int n = int.Parse(Console.ReadLine());
            // primarni niz
            int[] arr = new int[n];
            // unos elemenata u primarni niz
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            // sortiranje niza
            Array.Sort(arr);

            // pomocni niz
            int[] arrR = new int[n];

            // nulti i zadnji indeks niza
            int l = 0, d = n - 1;
            for(int i = 0; i < n; i++)
            {
                // ako je paran
                // u pomocni niz na index l++ stavi arr sa indexa i
                if (i % 2 == 0)
                    arrR[l++] = arr[i];
                    // ako je neparan onda na index d-- stavi arr sa indexa i
                else
                    arrR[d--] = arr[i];
            }

            // ispis svih el pomocnog niza
            for(int i = 0; i < n; i++)
                Console.WriteLine(arrR[i]);

            Console.ReadKey();
        }
    }
}
