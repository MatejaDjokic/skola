using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int mozeDo = 0;
        string[] str = Console.ReadLine().Split();

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(str[i]);

            if (x > mozeDo + 1) break;
            mozeDo += x;
        }
        Console.WriteLine(mozeDo + 1);
    }
}
