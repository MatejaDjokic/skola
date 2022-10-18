using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        //kb sluzi kao konacno odnosno rezultat i broj od 0 koliklo ima serija uzastopnih koja ima vise poena od p
        static bool DoWork(int[] no, int p, int n, int k)
        {
            int kb = 0;
            for (int i = 0; i < n; i++)//proverava se svaki broj niza da li je vec od p i timw se gledaju serije preko kb
                if (no[i] >= p)
                    kb++;//povecati seriju ako jeste
                else if (kb == k)//ako je duzina serije isto kao k jer je to uslov da ispise da, vrati tacan rez
                    return true;
                else //ako nije stavi ponovo kb seriju na 0 i ponovo ide postupak ispocetka
                    kb = 0;

            //vrati false, ako nije true
            return false;
        }

        static void Main()
        {
            int p, k, n;
            p = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[] no = new int[n];

            for (int i = 0; i < n; i++)
                no[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(DoWork(no, p, n, k) ? "da" : "ne");
            Console.ReadKey();
        }
    }
}