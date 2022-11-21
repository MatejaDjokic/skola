
using System;

public class Program
{
       
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string linija;
        while ((linija = Console.ReadLine()) != null)
        {
            string[] str = linija.Split();
            int a = int.Parse(str[0]);
            int d = int.Parse(str[1]);
            long S = a;
            int x = a;
            for (int i = 1; i < n; i++)
            {
                x += d;
                S += x;
            }
            double Skm = S / 1000.0;
            Console.WriteLine(Skm.ToString("0.00"));
        }
    }
}