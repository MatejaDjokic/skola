using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastavljanje_na_proste_cinioice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unos broja koji rastavljamo
            int n = int.Parse(Console.ReadLine());
            // prvi najmanji delilac 2 
            int f = 2;

            // ponavaljmo sve dok je n vece od 1 
            while(n > 1)
            {
                // ponavljamo sve dok je n podeljno sa f ceo broj
                while(n % f == 0)
                {
                    // ispisujemo f posto je n deljivo sa njim 
                    // time znaci da je jedan njegov cinioc
                    Console.Write(f + " ");
                    // onda delimo vrednost n sa f 
                    n /= f;
                }
                // povecavamo f za 1
                f++;
                // i ponvaljmo sve dok n vise nije deljivo sa f da je rezultat ceo broj
            }

            Console.ReadKey();
        }
    }
}
