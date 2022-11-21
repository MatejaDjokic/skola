using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace najduza_serija_pobeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // broj el u prim nizu
            int n = int.Parse(Console.ReadLine());
            // prim niz
            int[] arr = new int[n];

            // unos el u prim niz
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            // var pobede sa vrednoscu 0
            int pobede = 0;
            // temp var res sa pobede vrednoscu
            int res = pobede;
            // iteriranje n puta
            for(int i = 0; i < n; i++) {
                // ako je vrednost na poz i jednaka 1 tjst pobeda 
                // onda povecaj pobede 
                if (arr[i] == 1)
                    pobede++;
                // ako ne onda stavi na 0
                else
                    pobede = 0;
                // razmenjivanje vrednosti po uslovu
                // ako su pobede vece od res, sto i jesu na pocetku posto je res = 0
                // u res stavljamo vrednost od pobeda, cuvamo kao maks vrednost 
                if (pobede > res)
                    res = pobede;
            }
            // ispisujemo maks pobeda tjst. res
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
