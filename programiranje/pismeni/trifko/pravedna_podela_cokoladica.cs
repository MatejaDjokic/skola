using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravedna_podela_cokoladica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // broj elemenata prim niza
            int n = int.Parse(Console.ReadLine());
            // prim niz
            int[] arr = new int[n];
            // unosni string niz
            string[] str = Console.ReadLine().Split();
            // unos iz unosnog string niza u prim niz
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(str[i]);

            // broj dece
            int k = int.Parse(Console.ReadLine());

            // sortiranje prim niza
            Array.Sort(arr);

            // min = int max vrednost 
            int min = int.MaxValue;
            // i + k - 1 je manje od n
            for (int i = 0; i + k - 1 < n; i++)
            {
                // razlika je vredsnot sa i+k-1 prim niza i vrednost sa i prim niza
                int razlika = arr[i + k - 1] - arr[i];
                // ako je razlika manje od min 
                // razlika je novi min
                if (razlika < min)
                    min = razlika;
            }

            // ispis min-a
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
