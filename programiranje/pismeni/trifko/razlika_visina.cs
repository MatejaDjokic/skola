using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razlika_visina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unosimo zaljenu razliku
            int razlika = int.Parse(Console.ReadLine());
            // broje el prim niza
            int n = int.Parse(Console.ReadLine());
            // prim niz
            int[] arr = new int[n];
            // unos prim niza
            for(int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            // sortiranje niza
            Array.Sort(arr);

            // broj razlika jednakih zaljenoj razlici
            int res = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[j] - arr[i] == razlika){
                        res++;
                    }
                    else if(arr[j] - arr[i] > razlika)
                        break;

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

/*
1   1     n * 1.0
2   3     n * 1.5
3   6     n * 2.0
4   10    n * 2.5
5   15    n * 3.0
6   21    n * 3.5
7   28    n * 4.0
8   36    n * 4.5
9   45    n * 5.0
10  55    n * 5.5

multiplier = n / 2 + 0.5

*/
