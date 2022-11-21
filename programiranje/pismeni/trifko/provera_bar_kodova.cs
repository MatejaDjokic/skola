using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provera_bar_kodova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unosimo broj el u nizu
            int n = int.Parse(Console.ReadLine());
            // unosimo niz
            int[] a = new int[n];
            // unosni string niz
            string[] str = Console.ReadLine().Split();  
            // mapiranje vrednosti iz string unosnog niza u prim niz     
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(str[i]);

            // brojac rezultat
            int res = 0;

            // citamo liniju
            string line;
            // proveravamo da li je linija prazna
            while ((line = Console.ReadLine()) != "")
            {
                // ako nije prazna parsujemo vrednost linije iz stringa u int
                int x = int.Parse(line);
                // vrsimo binarnu pretragu u listi a prema x i proveravamo da li je ta vrednost veca ili jednaka nuli
                if (Array.BinarySearch(a, x) >= 0)
                    // ako jeste inkrementujemo brojac rezultat
                    res++;
            }

            // ispisujemo vrednost brojaca razultat
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
