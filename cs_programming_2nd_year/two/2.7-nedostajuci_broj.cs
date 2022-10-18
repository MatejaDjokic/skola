using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        string[] str = Console.ReadLine().Split();

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(str[i]);
            
        for (int x = 0; x <= n; x++)
            if (!Array.Exists(a, y => y == x))
            {
                Console.WriteLine(x);
                break;
            }
    }
}