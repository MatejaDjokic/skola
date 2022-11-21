using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> niz = new List<int>(n);
        List<int> niz2 = new List<int>(n);
        List<int> niz3 = new List<int>(n);
        string[] str = Console.ReadLine().Split();
        for (int i = 0; i < n; i++) niz.Add(int.Parse(str[i]));

        for (int i = 0; i < niz.Count(); i++)
        {
            var x = (niz[i] % 2 == 0) ? niz[i] : 0;
            niz2.Add (x);
            niz2.Remove(0);
            niz2.Sort();
        }
        for (int i = 0; i < niz.Count(); i++)
        {
            var x = (niz[i] % 2 != 0) ? niz[i] : 0;
            niz3.Add (x);
            niz3.Remove(0);
            niz3.Sort();
        }
        foreach (int a in niz2) Console.Write(a + " ");
        foreach (int a in niz3) Console.Write(a + " ");

        Console.Write("COMPLETED");
        Console.Write("\n");
    }
}

/*
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    string[] str = Console.ReadLine().Split();
    List<int> parni = new List<int>();
    List<int> neparni = new List<int>();
    for (int i = 0; i < n; i++)
    {
        a[i] = int.Parse(str[i]);
        if (a[i] % 2 == 0)
            parni.Add(a[i]);
        else if (a[i] % 2 != 0)
            neparni.Add(a[i]);
    }
    foreach (var x in parni)
        Console.Write(x + " ");
    foreach (var x in neparni)
        Console.Write(x + " ");
    }
}
*/