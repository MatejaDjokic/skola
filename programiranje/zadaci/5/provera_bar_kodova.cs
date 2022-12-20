using System;
using System.Collections.Generic;

class Program
{
    static bool sadrzi(int[] a, int l, int d, int x)
    {
        if (l > d)
            return false;
        int s = l + (d - l) / 2;
        if (x < a[s])
            return sadrzi(a, l, s - 1, x);
        else if (x > a[s])
            return sadrzi(a, s + 1, d, x);
        else
            return true;
    }
    
    static bool sadrzi(int[] a, int x)
    {
        return sadrzi(a, 0, a.Length - 1, x);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        string[] str = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(str[i]);
        int broj = 0;
        string s;
        while ((s = Console.ReadLine()) != null) {
            int x = int.Parse(s);
            if (sadrzi(a, x))
                broj++;
        }
        Console.WriteLine(broj);
    }
}