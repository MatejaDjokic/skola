using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

        int max = 0;
        for (int i = 0; i < n; i++)
        {
            int z = 0;
            for (int j = i; j < n; j++)
            {
                z += a[j];
                if (z > max) 
                    max = z;
            }
        }

        Console.WriteLine (max);
    }
}
