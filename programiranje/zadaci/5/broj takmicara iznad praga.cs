
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> resenja = new List<int>();
            int[] points = new int[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = int.Parse(Console.ReadLine());
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                int unos = int.Parse(Console.ReadLine());
                int count = points.Count(p => p >= unos);
                resenja.Add(count);
            }
            foreach (int br in resenja)
                Console.WriteLine(br);

            Console.ReadKey();        
        }
}