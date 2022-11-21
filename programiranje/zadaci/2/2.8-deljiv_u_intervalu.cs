using System;

class Program
{
    static void Main()
    {
        int a, b, k;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        int broj = 0;
        for (int i = a; i <= b; i++)
            if (i % k == 0)
                broj++;
        Console.WriteLine(broj);
    }
}