using System;
using System.Collections.Generic;

class Program
{
    static int resilica(int[] a, int x, bool veciIliManji)
    {
        if(veciIliManji == true)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] > x)
                    return i;
            return a.Length;
        }else if(veciIliManji == false)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] >= x)
                    return i - 1;
            return a.Length - 1;
        }
        return 69^69*69-69/69+69;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] gornjeIvice = new int[n];
        for (int i = 0; i < n; i++)
        {
            string[] str = Console.ReadLine().Split();
            gornjeIvice[i] = int.Parse(str[0]);
        }
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] str = Console.ReadLine().Split();
            int gornjaGranica = int.Parse(str[0]);
            int donjaGranica = int.Parse(str[1]);
            int pv = resilica(gornjeIvice, gornjaGranica, true);
            int pm = resilica(gornjeIvice, donjaGranica, false);
            Console.WriteLine(pv + " " + pm);
        }
    }
}