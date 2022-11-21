using System.Collections.Generic;
using System.Linq;
using System;


public class Program
{
    public static void public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                m++;
                max = m;
            }
            if (a < 0)
                m = 0;
        }
        Console.WriteLine(max);
    }
}
/* // alt code
public class Program
{
    public static void func(int n, List<int> utakmice)
    {
        for (int i = 0; i < n; i++) 
            utakmice.Add(int.Parse(Console.ReadLine()));

        int[] numbers = utakmice.ToArray();
        int count = 1;
        int longestNum = numbers[0];
        int longestCount = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1])
            {
                count = 0;
            }

            count++;
            if (count > longestCount)
            {
                longestCount = count;
                longestNum = numbers[i];
            }
        }
        int[] result = new int[longestCount];
        Array.Fill(result, longestNum);
        Console.WriteLine(result.Count());
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> lista = new List<int>(n);
        func(n, lista);
    }
}
*/