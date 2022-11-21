using System;

public class Program
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int n = s.Length;
        int br = 0;
        for (int i = 0; i < n - 1; i++)
            if (s[i] == '1')
                for (int j = i + 1; j < n; j++)
                    if (s[j] == '1')
                        br++;
        Console.WriteLine(br);
    }
}