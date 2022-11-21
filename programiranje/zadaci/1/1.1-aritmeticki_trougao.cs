using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static long zbirRedaTrougle(long k)
    {
        long pocetak = 1;
        long brojElemenata = 1;

        for (long i = 1; i <= k; i++)
        {
            pocetak += brojElemenata;
            brojElemenata += 2;
        }

        long zbir = 0;
        for (long i = pocetak; i <= pocetak + brojElemenata; i++) zbir += i;
        return zbir;
    }

    public static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            long k = long.Parse(Console.ReadLine());
            Console.WriteLine(zbirRedaTrougle(k));
        }
        Console.Write("COMPLETED");
        Console.Write("\n");
    }
}
