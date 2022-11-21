using System;
using System.Collections.Generic;
using System.Linq;

public class RazlikaVisina {
    public static void Main(string[] args) {
        int r = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n*n];
        int brojac = 0;

        for (int i = 0; i < n; i++) {
            a[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n*n; i++) {
            for (int j = 0; j < n*n; j++) {
                b[i] = Math.Abs(a[i] - a[j]);
            }
        }


        Console.WriteLine("--------------------");

        foreach (var item in b) {
            Console.Write(item + " ");
        }

        Console.WriteLine("--------------------");
        
        for (int i = 0; i < n*n; i++) {
            if(b[i] == r)
                brojac++;
        }
        Console.WriteLine(brojac);
    }
}
/*
2350
5
15745
18095
15745
16234
13395
*/