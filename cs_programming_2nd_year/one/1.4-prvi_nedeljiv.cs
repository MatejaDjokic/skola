using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] a = new long[n];
        string[] str = Console.ReadLine().Split();
        for (int i = 0; i < n; i++) a[i] = long.Parse(str[i]);
        string linija;
        while ((linija = Console.ReadLine()) != null)
        {
            long k = long.Parse(linija);
            int
                l = 0,
                d = n - 1;
            while (l <= d)
            {
                int s = l + (d - l) / 2;
                if (a[s] % k != 0)
                    d = s - 1;
                else
                    l = s + 1;
            }
            Console.WriteLine (l);
        }
    }
}
